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
using ProjectManhattan.Client.BL.Pages;
using ProjectManhattanApp.Fragments;

namespace ProjectManhattanApp.Activities
{
    [Activity(Label = "NowPlayingActivity")]
    public class MovieDetailActivity : Activity
    {
        Fragment[] _fragments;

        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.md_activity_NowPlaying);

            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;

            // Get the movie based on the ID
            var mid = Intent.GetStringExtra("MovieId");
            var movieId = Convert.ToInt32(mid);
            var movie = await new NowPlayingPage().GetNowPlayingData(movieId);

            var movieTrailer = await new NowPlayingPage().GetMovieTrailerData(movieId);
            

            _fragments = new Fragment[]
             {
                             md_DetailFragment.NewInstance(movie,movieTrailer),
                             new md_RatingFragment(movie,this.Assets),
                             new md_SocialFragment(movie),
                             new md_GalleryFragment(movie),
                             new md_UserPicsFragment(movie),
             };
            AddTabToActionBar(Resource.String.Detail, Resource.Drawable.Icon);
            AddTabToActionBar(Resource.String.Ratings, Resource.Drawable.Icon);
            AddTabToActionBar(Resource.String.Social, Resource.Drawable.Icon);
            AddTabToActionBar(Resource.String.Gallery, Resource.Drawable.Icon);
            AddTabToActionBar(Resource.String.UserFeedback, Resource.Drawable.Icon);

            //Get all the resources to be filled
        }
        void AddTabToActionBar(int labelResourceId, int iconResourceId)
        {
            ActionBar.Tab tab = ActionBar.NewTab()
                                         .SetText(labelResourceId)
                                         .SetIcon(iconResourceId);
            tab.TabSelected += TabOnTabSelected;
            ActionBar.AddTab(tab);
        }

        void TabOnTabSelected(object sender, ActionBar.TabEventArgs tabEventArgs)
        {
            ActionBar.Tab tab = (ActionBar.Tab)sender;

            Fragment frag = _fragments[tab.Position];
            tabEventArgs.FragmentTransaction.Replace(Resource.Id.frameLayout1, frag);
        }

    }
}