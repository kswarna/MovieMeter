using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MovieMeter.Service;
using Xamarin.Forms;
using DTO;

namespace MovieMeter.Forms
{
    public class App : Application
    {
        //public static DataManager<Movie> MovieManager { get; private set; }
        public App()
        {
            //MovieManager = new DataManager<Movie>();
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
