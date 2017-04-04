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
using Android.Graphics;

namespace ProjectManhattanApp.Helper
{
    public static class ImageHelper
    {
        public static Bitmap DecodeByteArraytoBitmap( byte[] byteArray)
        {
            var imageBitmap = BitmapFactory.DecodeByteArray(byteArray, 0, byteArray.Length);
            return imageBitmap;
        }
    }
}