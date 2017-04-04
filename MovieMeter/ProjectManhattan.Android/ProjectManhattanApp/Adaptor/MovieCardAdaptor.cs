using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ProjectManhattan.DTO.DbTableDTO;
using ProjectManhattanApp.Helper;
using Android.Graphics;
using System.Net;

namespace ProjectManhattanApp.Adaptor
{
    public class MovieCardAdaptor : BaseAdapter<MovieSummaryDTO>
    {
        private readonly Activity context;
        private readonly List<MovieSummaryDTO> movies;
        public MovieCardAdaptor(Activity context, List<MovieSummaryDTO> movies)
        {
            this.context = context;
            this.movies = movies;
        }

        public override MovieSummaryDTO this[int position]
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override int Count
        {
            get
            {
                return movies.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            if (view == null)
            {
                view = context.LayoutInflater.Inflate(Resource.Layout.hs_row_MovieCard, parent, false);
            }

            var titleTextView = view.FindViewById<TextView>(Resource.Id.MovieName);
            var imageView = view.FindViewById<ImageView>(Resource.Id.imageView);

            titleTextView.Text = movies[position].Name;

            var Actors = view.FindViewById<TextView>(Resource.Id.Actors);
            var artists = "";
            foreach (var artist in movies[position].Artist)
            {
                artists += artist.ArtistName + "'";
            }
            var len = (artists.Length > 12 ? 12 : artists.Length);
            Actors.Text = movies[position].CriticRating.ToString();// artists.Substring(0,len).TrimEnd(',');

            var imageBitmap = ImageHelper.DecodeByteArraytoBitmap(movies[position].SmallPicture);
            imageView.SetImageBitmap(imageBitmap);

            var rating_panel = view.FindViewById<LinearLayout>(Resource.Id.ratingpanel);
            rating_panel.AddView(new Views.RatingView(view.Context,movies[position].CriticRating), 100, 100);

            return view;
        }

       
    }
      

        
}