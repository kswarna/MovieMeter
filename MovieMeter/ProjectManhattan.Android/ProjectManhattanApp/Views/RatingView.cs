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

namespace ProjectManhattanApp.Views
{
    public class RatingView : View
    {
        private decimal Rating;

        public RatingView(Context context, decimal rating) : base(context) {
            Rating = rating;
        }
        protected override void OnDraw(Canvas canvas)
        {
            int r = Convert.ToInt32((5 - Rating) * 51);
            int g = Convert.ToInt32((Rating) * 51);

            base.OnDraw(canvas);
            Paint color = new Paint
            {
                AntiAlias = true,
                Color = Color.Rgb(r, g, 0),
                StrokeWidth=9
            };
            color.SetStyle(Paint.Style.FillAndStroke);

            var outerWhite = new Paint() {
                Color = Color.Rgb(255, 255, 255),
                StrokeWidth = 7
            };
            outerWhite.SetStyle(Paint.Style.Stroke);

            var innerWhite = new Paint()
            {
                Color = Color.Rgb(255, 255, 255)
            };
            innerWhite.SetStyle(Paint.Style.FillAndStroke);

            canvas.DrawArc(new RectF(4, 4, canvas.Height * 8 / 10, canvas.Height * 8 / 10), 93, 346, false, outerWhite);

            var ratingPercent = (Rating / 5);
            // The reason we are multiplying into 330 and not 360 is because we want a range of 330 degree arc. We are adding 15 degrees as the arc is from 15 to 345 degree)
            var AngleinDegrees = ratingPercent * 330;
            var startingAngle = AngleinDegrees + 15;
            // converting to radians
            var AngleInRadian = Convert.ToDouble(startingAngle) * Math.PI / 180;

            float x = Convert.ToSingle( (canvas.Height / 2) - 7 + canvas.Height / 2 * Math.Cos(AngleInRadian));
            float y = Convert.ToSingle((canvas.Height / 2) - 7 + canvas.Height / 2 * Math.Sin(AngleInRadian));

            //canvas.Height / 2, canvas.Height / 2, canvas.Height * 8 / 20, outerWhite);
            canvas.DrawCircle((canvas.Height / 2)-7, (canvas.Height / 2)-7, canvas.Height * 5 / 20, innerWhite);

            canvas.DrawLine((canvas.Height / 2) - 7, (canvas.Height / 2) - 7, x, y,color);

                //120, 300, true, color);

            //            canvas.DrawRect(0, 0, middle, canvas.Height, green);
        }
    }
}