using Android.OS;
using Android.Views;
using Android.Widget;
using ProjectManhattan.DTO.DbTableDTO;
using Android.Webkit;

namespace ProjectManhattanApp.Fragments
{
    public class md_SocialFragment : md_tab_baseFragment
    {
        WebView mWebView;
        public md_SocialFragment(MovieDetailDTO movie) : base(movie)
        {
        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your fragment here
           
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            var view = inflater.Inflate(Resource.Layout.md_Tab_Social, container, false);
            name = view.FindViewById<TextView>(Resource.Id.np_name);
            mWebView = view.FindViewById<WebView>(Resource.Id.webView1);
            mWebView.Settings.JavaScriptEnabled = true;
            mWebView.SetWebViewClient(new WebViewClient());
            name.Text = Movie.Movie.Name;
            var url = string.Format("http://mmcomments.azurewebsites.net?identifier={0}", Movie.Movie.MovieId);
            mWebView.LoadUrl(url);
            return view;
        }
    }
}