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
    public class S3_cu : Activity
    {
        MediaPlayer _playerBCC;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.S3_cu);

            _playerBCC = MediaPlayer.Create(this, Resource.Raw.cu);
            _playerBCC.Start();

            ImageView Cu = FindViewById<ImageView>(Resource.Id.imgcu);
            ImageView TaJ = FindViewById<ImageView>(Resource.Id.imgtaj);
            Animation Zoom4 = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom4);
            TaJ.StartAnimation(Zoom4);

            Animation Zoom5 = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom5);
            Cu.StartAnimation(Zoom5);

            var next = FindViewById<ImageButton>(Resource.Id.ivtiep);
            next.Click += Next_Click;


        }
         void Next_Click(object sender, EventArgs e)
        {
            _playerBCC.Stop();
            Intent intent = new Intent(this, typeof(caohonthaphon));
            this.StartActivity(intent);

        } 

    }
}
