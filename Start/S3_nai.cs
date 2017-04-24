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
    public class S3_nai : Activity
    {
        MediaPlayer _playerBCC;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.S3_nai);

            _playerBCC = MediaPlayer.Create(this, Resource.Raw.nai);
            _playerBCC.Start();

            ImageView Nai = FindViewById<ImageView>(Resource.Id.nai);
            ImageView TaJ = FindViewById<ImageView>(Resource.Id.taj_nai);
            Animation Zoom3 = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom3);
            Nai.StartAnimation(Zoom3);

            Animation Zoom2 = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom2);
            TaJ.StartAnimation(Zoom2);

            var next = FindViewById<ImageButton>(Resource.Id.ivtiep);
            next.Click += Next_Click;


        }
        void Next_Click(object sender, EventArgs e)
        {
            _playerBCC.Stop();
            Intent intent = new Intent(this, typeof(TohonNhohon));
            this.StartActivity(intent);

        }

    }
}
