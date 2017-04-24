using System;
using Android.Content;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Media;
using Android.Views;

namespace Start
{
    [Activity(ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize | Android.Content.PM.ConfigChanges.Orientation, ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]

    public class MainActivity : Activity
    {
        MediaPlayer _playerNhacnen;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            _playerNhacnen = MediaPlayer.Create(this, Resource.Raw.audionen);
            _playerNhacnen.Start();
            _playerNhacnen.SetVolume(.1f, .1f);
            _playerNhacnen.Looping = true;

            var Play = FindViewById<ImageButton>(Resource.Id.imgplay);
            Play.Click += playbtn_Click;
            var Exit = FindViewById<ImageButton>(Resource.Id.imgexit);
            Exit.Click += Exit_Click;
            var Caidat = FindViewById<ImageButton>(Resource.Id.imgsetting);
            Caidat.Click += Caidat_Click;
            
        }
        void playbtn_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Story));
            this.StartActivity(intent);

        }
        void Exit_Click(object sender, EventArgs e)
        {
            _playerNhacnen.Stop();
            this.FinishAffinity();
        }
        void Caidat_Click(object sender, EventArgs e)
        {
            _playerNhacnen.Stop();

        }

    }
}


