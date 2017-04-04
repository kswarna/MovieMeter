using System;
using Android.OS;
using Android.Util;
using ProjectManhattanApp.Fragments;
using Android.App;
using ProjectManhattan.Client.BL.Pages;
using Android.Widget;
using ProjectManhattan.DTO.DbTableDTO;
using System.Collections.Generic;
using ProjectManhattanApp.Adaptor;
using Android.Content;
using System.Linq;


namespace ProjectManhattanApp.Activities
{
    [Android.App.Activity(Label = "Movie Meter", MainLauncher = true, Icon = "@drawable/icon")]
    public class HomeScreenActivity : Activity
    {
        //ListView moviesListView;
        LinearLayout NowPlaying;
        LinearLayout ComingSoon;
        TextView Nptv;
        TextView Cstv;
        Gallery NpGallery;
        Gallery CsGallery;
        List<MovieSummaryDTO> npMovies;
        List<MovieSummaryDTO> csMovies;
        RadioGroup radioGroup;
        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_HomeScreen);

            var movies =  await new HomeScreenPage().GetMovies();
            npMovies = movies.Where(x => x.HasReleased).ToList();
            csMovies = movies.Where(x => !x.HasReleased).ToList();
            NowPlaying = FindViewById<LinearLayout>(Resource.Id.now_playing);
            ComingSoon = FindViewById<LinearLayout>(Resource.Id.coming_soon);

            Nptv = NowPlaying.FindViewById<TextView>(Resource.Id.MovText);
            Nptv.Text = "Now Playing";
            Cstv = ComingSoon.FindViewById<TextView>(Resource.Id.MovText);
            Cstv.Text = "Coming soon";

            NpGallery = NowPlaying.FindViewById<Gallery>(Resource.Id.GalleryView);
            CsGallery = ComingSoon.FindViewById<Gallery>(Resource.Id.GalleryView);

            //NpGallery = FindViewById<Gallery>(Resource.Id.GalleryView);
            //CsGallery = FindViewById<Gallery>(Resource.Id.GalleryView2);

            var editText1 = FindViewById<EditText>(Resource.Id.editText1);
            radioGroup = FindViewById<RadioGroup>(Resource.Id.radioGroup);
            editText1.TextChanged += Onsearch;
            radioGroup.CheckedChange += onCheckedChanged;
            PopulateList();
        }


        private void PopulateList()
        {
            MovieCardAdaptor moviesAdapter;
            MovieCardAdaptor moviesAdapter2;
            var rdbtnChecked = radioGroup.GetChildAt(radioGroup.CheckedRadioButtonId);

//            if (radioGroup.CheckedRadioButtonId == Resource.Id.radioNowPlaying)
                moviesAdapter = new MovieCardAdaptor(this, npMovies);
  //          else            
                moviesAdapter2 = new MovieCardAdaptor(this, csMovies);
            
            
            if (NpGallery != null)
            {
                NpGallery.ItemClick += OnListItemClick;
                NpGallery.Adapter = moviesAdapter;
            }
            if (CsGallery != null)
            {
                CsGallery.ItemClick += OnListItemClick;
                CsGallery.Adapter = moviesAdapter2;
            }
            //else
            //{
            //    moviesListView.ItemClick += OnListItemClick;
            //    moviesListView.Adapter = moviesAdapter;
            //}
        }

        private void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var detailsIntent = new Intent(this, typeof(MovieDetailActivity));
            var mid = "";
            var rdbtnChecked = radioGroup.GetChildAt(radioGroup.CheckedRadioButtonId);

            if (radioGroup.CheckedRadioButtonId == Resource.Id.radioNowPlaying)
                mid = npMovies[e.Position].MovieId.ToString();
            else
                mid = csMovies[e.Position].MovieId.ToString();

            detailsIntent.PutExtra("MovieId", mid);
            StartActivity(detailsIntent);
        }

        private async void Onsearch(object sender, Android.Text.TextChangedEventArgs e)
        {
            List<MovieSummaryDTO> movies;
            if (!string.IsNullOrWhiteSpace(e.Text.ToString()))
            {
                movies = await new HomeScreenPage().SearchMovies(e.Text.ToString());
            }
            else
            {
                movies = await new HomeScreenPage().GetMovies();
            }
            npMovies = movies.Where(x => x.HasReleased).ToList();
            csMovies = movies.Where(x => !x.HasReleased).ToList();
            PopulateList();

        }

        private void onCheckedChanged(object sender, RadioGroup.CheckedChangeEventArgs e)
        {
            PopulateList();
        }

     
    }
}

