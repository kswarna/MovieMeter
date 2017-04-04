using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlobDataAccess.AzureBlobAccess;
using ProjectManhattanModel;

public partial class Gallery : System.Web.UI.Page
{
    public static Dictionary<int, Movie> Movies
    {
        get; set;
    }

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Movies == null || !Movies.Any())
        {
            using (var dataContext = new ProjectManhattanEntities1())
            {
                Movies = dataContext.Movies
                    .Include("Language").ToDictionary(m => m.MovieId, m => m);

            }
        }


        if (!IsPostBack)
        {
            RadioButtonList1.DataSource = Movies.Values.ToList();
            RadioButtonList1.DataBind();
        }
    }

    protected void btnCreateContainers_OnClick(object sender, EventArgs e)
    {
        AzureContainer azureContainer = new AzureContainer("StorageConnectionString");

        using (var dataContext = new ProjectManhattanEntities1())
        {
            var movies = dataContext.Movies.ToList();
            foreach (var movie in movies)
            {
                var containerName = GetMovieContainerName(movie);
                azureContainer.GetOrCreateContainer(containerName);
            }
        }
    }

    private static string GetMovieContainerName(Movie movie)
    {
        var containerName = string.Format("{0}-{1}", movie.Name, movie.MovieId);
        containerName = containerName.Replace(".", "").Replace(" ", "").ToLower();
        return containerName;
    }

    protected void btnSyncMoviePhotos_OnClick(object sender, EventArgs e)
    {
        AzureContainer azureContainer = new AzureContainer("StorageConnectionString");
        using (var dataContext = new ProjectManhattanEntities1())
        {
            var movies = dataContext.Movies
                .Include("MoviePhotoes")
                .ToList();
            bool isNewMoviePhotosAvailable = false;
            foreach (var movie in movies)
            {
                var containerName = GetMovieContainerName(movie);
                var existingPhotosInDB = new HashSet<string>(movie.MoviePhotoes.Select(m => m.MoviePhotoURL));

                foreach (var uri in azureContainer.GetListFiles(containerName))
                {
                    var photoURL = uri.OriginalString;
                    if (!existingPhotosInDB.Contains(photoURL))
                    {
                        //Insert the missing movie photo
                        MoviePhoto moviePhoto = new MoviePhoto()
                        {
                            MovieId = movie.MovieId,
                            MoviePhotoURL = photoURL,

                        };
                        dataContext.MoviePhotoes.AddObject(moviePhoto);
                        isNewMoviePhotosAvailable = true;
                    }
                }
            }
            if (isNewMoviePhotosAvailable)
                dataContext.SaveChanges();
        }
    }

    public static int? SelectedMovieId { get; set; }

    protected void MovieSelectionChanged(object sender, EventArgs e)
    {
        lblSelectedMovie.Text = RadioButtonList1.SelectedItem.Text;
        var movieId = 0;
        if (int.TryParse(RadioButtonList1.SelectedValue, out movieId))
        {
            SelectedMovieId = movieId;
            RefreshPhotos();
        }
    }

    private void RefreshPhotos()
    {
        if(!SelectedMovieId.HasValue)
            return;

        var movie = Movies[SelectedMovieId.Value];
        var containerName = GetMovieContainerName(movie);
        AzureContainer azureContainer = new AzureContainer("StorageConnectionString");
        var files = azureContainer.GetListFiles(containerName);
        CheckBoxList1.DataSource = files.Select(f => System.IO.Path.GetFileName(f.OriginalString)).ToList();
        CheckBoxList1.DataBind();
    }

    protected void UploadClick(object sender, EventArgs e)
    {
        if (!SelectedMovieId.HasValue)
        {
            lblSelectedMovie.Text = "Please select a movie";
            return;
        }

        if (!FileUpload1.HasFiles)
            return;

        var movie = Movies[SelectedMovieId.Value];

        AzureContainer azureContainer = new AzureContainer("StorageConnectionString");
        azureContainer.SetContainer(GetMovieContainerName(movie));

        bool isNewMoviePhotosAvailable = false;
        var files = FileUpload1.PostedFiles;
        using (var dataContext = new ProjectManhattanEntities1())
        {
            foreach (var file in files)
            {
                var photoURL = azureContainer.StoreFile(file.FileName, file.InputStream);

                MoviePhoto moviePhoto = dataContext.MoviePhotoes
                        .Where(m => m.MovieId == SelectedMovieId.Value).ToList()
                        .FirstOrDefault(m =>
                            string.Equals(Path.GetFileName(m.MoviePhotoURL),
                                Path.GetFileName(photoURL),
                                StringComparison.CurrentCultureIgnoreCase));

                if (moviePhoto == null)
                {
                    moviePhoto = new MoviePhoto()
                    {
                        MovieId = movie.MovieId,
                        MoviePhotoURL = photoURL,

                    };

                    dataContext.MoviePhotoes.AddObject(moviePhoto);
                    isNewMoviePhotosAvailable = true;
                }
            }

            if (isNewMoviePhotosAvailable)
            {
                dataContext.SaveChanges();
                RefreshPhotos();
            }
        }



    }

    protected void btnDeleteSelectedFiles_OnClick(object sender, EventArgs e)
    {
        if (!SelectedMovieId.HasValue)
        {
            lblSelectedMovie.Text = "Please select a movie";
            return;
        }

        var movie = Movies[SelectedMovieId.Value];
        AzureContainer azureContainer = new AzureContainer("StorageConnectionString");
        azureContainer.SetContainer(GetMovieContainerName(movie));

        var items = CheckBoxList1.Items;
        using (var dataContext = new ProjectManhattanEntities1())
        {
            foreach (ListItem item in items)
            {
                if (item.Selected)
                {

                    azureContainer.DeleteFile(item.Text);

                    var moviePhoto = dataContext.MoviePhotoes
                        .Where(m => m.MovieId == SelectedMovieId.Value).ToList()
                        .FirstOrDefault(m =>
                            string.Equals(Path.GetFileName(m.MoviePhotoURL),
                                item.Text,
                                StringComparison.CurrentCultureIgnoreCase));

                    dataContext.MoviePhotoes.DeleteObject(moviePhoto);
                    dataContext.SaveChanges();
                }
            }
            RefreshPhotos();
        }
    }
}