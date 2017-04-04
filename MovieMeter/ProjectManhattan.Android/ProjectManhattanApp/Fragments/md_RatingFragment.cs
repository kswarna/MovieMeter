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
using Android.Webkit;
using System.IO;
using Android.Content.Res;

namespace ProjectManhattanApp.Fragments
{
    public class md_RatingFragment : md_tab_baseFragment
    {
        public md_RatingFragment(MovieDetailDTO movie, AssetManager assets) : base(movie)
        {
            Assets = assets;
        }
        AssetManager Assets;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            var view = inflater.Inflate(Resource.Layout.md_tab_Rating, container, false);
            name = view.FindViewById<TextView>(Resource.Id.np_name);
            name.Text = Movie.Movie.Name;
            string content = "<html><head><meta name=\"viewport\" content=\"width=device-width, initial-scale=1, maximum-scale=1\"></head><body>    <div id=\"disqus_thread\"></div>    there    <script>    var disqus_config = function () {        this.page.identifier =1;};        (function () { var d = document, s = d.createElement('script');    s.src = '//projectmanhattan.disqus.com/embed.js';    s.setAttribute('data-timestamp', +new Date());    (d.head || d.body).appendChild(s);})();    </script>    <noscript>Please enable JavaScript to view the <a href=\"http://disqus.com/?ref_noscript\">comments powered by Disqus.</a></noscript>    <a href=\"http://disqus.com\" class=\"dsq-brlink\"></a></body></html>";
            var mWebView = view.FindViewById<WebView>(Resource.Id.webView1);
            mWebView.Settings.JavaScriptEnabled = true;
            mWebView.SetWebChromeClient(new WebChromeClient());
            //mWebView.LoadUrl("file:///android_asset/Comments/default.html");
            mWebView.LoadData(content, "text/html", "UTF-8");
            return view;
        }
    }
}