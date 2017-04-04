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
    public class md_tab_baseFragment : Fragment
    {
        protected MovieDetailDTO Movie;
        protected TextView name;

        public md_tab_baseFragment()
        { 
        
        }

        public md_tab_baseFragment(MovieDetailDTO movie)
        {
            Movie = movie;
        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            //// Use this to return your custom view for this Fragment
            //var view = inflater.Inflate(Resource.Layout.md_Tab_Gallery, container, false);
            //name = view.FindViewById<TextView>(Resource.Id.np_name);
            //return view;
            return base.OnCreateView(inflater, container, savedInstanceState);
        }
    }
}