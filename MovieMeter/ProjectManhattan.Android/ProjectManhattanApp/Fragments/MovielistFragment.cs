using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using ProjectManhattan.Client.BL.Pages;
using ProjectManhattanApp.Adaptor;
using ProjectManhattan.DTO.DbTableDTO;
using ProjectManhattanApp.Activities;

namespace ProjectManhattanApp.Fragments
{
    public class MovieBannerListFragment : Fragment
    {
        public MovieBannerListFragment()
        {
        }

        public MovieBannerListFragment(bool nowPlaying)
        {
            NowPlaying = nowPlaying;
        }
        bool NowPlaying = true;
        ListView moviesListView;
        Gallery Gallery;
        List<MovieSummaryDTO> movies;

        public override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            if (NowPlaying)
            {
                movies = await new HomeScreenPage().GetNowPlayingData();                
            }
            else
            {
                movies = await new HomeScreenPage().GetComingSoonData();
            }
            NewMethod();

        }

        private void NewMethod()
        {
            var moviesAdapter = new MovieCardAdaptor(this.Activity, movies);
            if (Gallery != null)
            {
                Gallery.ItemClick += OnListItemClick;
                Gallery.Adapter = moviesAdapter;
            }
            else
            {
                moviesListView.ItemClick += OnListItemClick;
                moviesListView.Adapter = moviesAdapter;
            }
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.hs_fragment_moviesList, container, false);

            var editText1 = view.FindViewById<EditText>(Resource.Id.editText1);
            editText1.TextChanged += Onsearch;
            Gallery = view.FindViewById<Gallery>(Resource.Id.GalleryView);
            //moviesListView = view.FindViewById<ListView>(Resource.Id.moviesListView);
            return view;
        }
        private void OnListItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var detailsIntent = new Intent(Activity, typeof(MovieDetailActivity));
            var mid = movies[e.Position].MovieId.ToString();
            detailsIntent.PutExtra("MovieId", mid);
            StartActivity(detailsIntent);
        }
        private async void Onsearch(object sender, Android.Text.TextChangedEventArgs e)
        {
            movies = await new HomeScreenPage().SearchMovies(e.Text.ToString());
            NewMethod();

        }
    }
}