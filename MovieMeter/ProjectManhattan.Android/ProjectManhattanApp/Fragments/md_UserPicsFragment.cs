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

namespace ProjectManhattanApp.Fragments
{
    public class md_UserPicsFragment : md_tab_baseFragment
    {
        public md_UserPicsFragment(MovieDetailDTO movie) : base(movie)
        {
        }


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            var view = inflater.Inflate(Resource.Layout.md_Tab_UserPics, container, false);
            name = view.FindViewById<TextView>(Resource.Id.np_name);
            return view;
        }
    }
}