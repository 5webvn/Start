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
using Android.Media;
using Android.Animation;
using Android.Views.Animations;


namespace Start
{
    [Activity(ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize | Android.Content.PM.ConfigChanges.Orientation, ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
    public class S3_ran : Activity
    {
        MediaPlayer _playerBCC;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.S3_ran);

            _playerBCC = MediaPlayer.Create(this, Resource.Raw.ran);
            _playerBCC.Start();

            ImageView Ran = FindViewById<ImageView>(Resource.Id.imgran);
            ImageView TaJ = FindViewById<ImageView>(Resource.Id.imgtaj_ran);
            Animation Zoom6 = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom6);
            Ran.StartAnimation(Zoom6);

            Animation Zoom7 = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom7);
            TaJ.StartAnimation(Zoom7);

            var next = FindViewById<ImageButton>(Resource.Id.ivtiep);
            next.Click += Next_Click;


        }
        void Next_Click(object sender, EventArgs e)
        {
            _playerBCC.Stop();
            Intent intent = new Intent(this, typeof(daihonnganhon));
            this.StartActivity(intent);

        }

    }
}
