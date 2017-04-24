using System;
using System.Collections.Generic;
using System.Linq;
using Android.Content;
using Android.Runtime;
using Android.App;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Widget;
using Android.Views.Animations;
using Android.Views;


namespace Start
{
    [Activity(ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize | Android.Content.PM.ConfigChanges.Orientation, ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
    public class S3 : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.S3);
            var Play = FindViewById<ImageButton>(Resource.Id.imgplay);
            Play.Click += playbtn_Click;
            var Stop = FindViewById<ImageButton>(Resource.Id.imgexit);
            Stop.Click += Stop_Click;
        }
        void playbtn_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(S3_voi));
            this.StartActivity(intent);

        }
        void Stop_Click(object sender, EventArgs e)
        {

            Intent intent = new Intent(this, typeof(MainActivity));
            this.StartActivity(intent);
        }

    }
}