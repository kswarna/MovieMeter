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
using ProjectManhattan.DTO.DbTableDTO;
using ProjectManhattanApp.Helper;
using Android.Webkit;
using Newtonsoft.Json;
using ProjectManhattan.Client.BL.Pages;

namespace ProjectManhattanApp.Fragments
{
    public class md_DetailFragment : md_tab_baseFragment
    {
        private static  String MovieDetail_Key = "MovieDetail";
        private static String MovieTrailer_Key = "MovieTrailer";
        private string MovieTrailerUrl;

        TextView criticRating;
        TextView userRating;
        RatingBar ratingbar;
        ImageView ratingImage;
        WebView MovieTrailer;
        ImageView BackgroundImage;

        
        public static md_DetailFragment NewInstance(MovieDetailDTO movie, List<MovieTrailerDTO> movieTrailer)
        {
            var detailsFrag = new md_DetailFragment { Arguments = new Bundle() };
            Bundle bundle = new Bundle();
            bundle.PutString(MovieDetail_Key, JsonConvert.SerializeObject(movie));
            bundle.PutString(MovieTrailer_Key, JsonConvert.SerializeObject(movieTrailer));
            detailsFrag.Arguments = bundle;

            return detailsFrag;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            Movie = JsonConvert.DeserializeObject<MovieDetailDTO>(this.Arguments.GetString(MovieDetail_Key));
            var movieTrailer = JsonConvert.DeserializeObject<List<MovieTrailerDTO>>(this.Arguments.GetString(MovieTrailer_Key));
            MovieTrailerUrl = movieTrailer.Select(x => x.TrailerPath).SingleOrDefault();            
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
          
            // Use this to return your custom view for this Fragment
            var metrics = Resources.DisplayMetrics;
            var view = inflater.Inflate(Resource.Layout.md_tab_Detail, container, false);
            name = view.FindViewById<TextView>(Resource.Id.np_name);
            criticRating = view.FindViewById<TextView>(Resource.Id.md_CriticRating);
            userRating = view.FindViewById<TextView>(Resource.Id.md_UserRating);
            ratingbar = view.FindViewById<RatingBar>(Resource.Id.ratingBar1);
            ratingImage = view.FindViewById<ImageView>(Resource.Id.imageView1);
            //BackgroundImage = view.FindViewById<ImageView>(Resource.Id.np_imageView);
            name.Text = Movie.Movie.Name;
            
            #region Display Ratings

            decimal cr = 0;
            int crCount = 0;
            decimal ur = 0;
            int urCount = 0;
            foreach (var rat in Movie.CriticRatings)
            {
                if (rat.Rating.HasValue)
                {
                    cr += rat.Rating.Value;
                    crCount++;
                }
            }
            foreach (var rat in Movie.UserRatings)
            {
                if (rat.Rating.HasValue)
                {
                    ur += rat.Rating.Value;
                    urCount++;
                }
            }
            if (crCount > 0)
            {
                criticRating.Text = String.Format("{0}", cr / crCount);
            }
            if (urCount > 0)
            {
                userRating.Text = String.Format("{0}", ur / urCount);
            }

            ratingbar.RatingBarChange += (o, e) =>
            {
                if (ratingbar.Rating > 4)
                {
                    ratingImage.SetBackgroundResource(Resource.Drawable.sm_5);
                }
                else if (ratingbar.Rating > 3)
                {
                    ratingImage.SetBackgroundResource(Resource.Drawable.sm_4);
                }
                else if (ratingbar.Rating > 2)
                {
                    ratingImage.SetBackgroundResource(Resource.Drawable.sm_3);
                }
                else if (ratingbar.Rating > 1)
                {
                    ratingImage.SetBackgroundResource(Resource.Drawable.sm_2);
                }
                else
                {
                    ratingImage.SetBackgroundResource(Resource.Drawable.sm_1);
                }
            };

            #endregion

            //var imageBitmap = ImageHelper.DecodeByteArraytoBitmap(Movie.Movie.LargePicture);
            //BackgroundImage.SetImageBitmap(imageBitmap);

            #region Movie trailer in WebView

            MovieTrailer = view.FindViewById<WebView>(Resource.Id.np_videoView);
            
            int intDisplayWidth = metrics.WidthPixels+100;
            int intDisplayHeight =Convert.ToInt16( metrics.WidthPixels * (10.0/16.0));
            
            string html = @"<html><body><iframe width=""videoWidth"" height=""videoHeight"" src=""MovieTrailerUrl"" allowfullscreen></iframe></body></html>";

            var trailerWebChromeClient = new WebChromeClient();
            trailerWebChromeClient.OnShowCustomView(view, null);

            var settings = MovieTrailer.Settings;
            settings.JavaScriptEnabled = true;
            settings.UseWideViewPort = true;
            settings.LoadWithOverviewMode = true;
            settings.JavaScriptCanOpenWindowsAutomatically = true;
            settings.DomStorageEnabled = true;
            settings.SetRenderPriority(WebSettings.RenderPriority.High);
            settings.BuiltInZoomControls = false;
            settings.JavaScriptCanOpenWindowsAutomatically = true;
            MovieTrailer.SetWebChromeClient(trailerWebChromeClient);
            settings.AllowFileAccess = true;
            settings.SetPluginState(WebSettings.PluginState.On);
            string strYouTubeURL = html.Replace("videoWidth", intDisplayWidth.ToString()).Replace("videoHeight", intDisplayHeight.ToString()).Replace("MovieTrailerUrl", MovieTrailerUrl);

            MovieTrailer.LoadDataWithBaseURL(null, strYouTubeURL, "text/html", "UTF-8", null); 

            #endregion

            return view;
        }
        
        int FnConvertPixelsToDp(float pixelValue)
        {
            var dp = (int)((pixelValue) / Resources.DisplayMetrics.Density);
            return dp;
        }
    }
}
