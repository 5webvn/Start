using System;
using Android.App;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Views.Animations;
using Android.Content.PM;
using Android.Media;
using Android.Content;

namespace Start
{
    [Activity(ConfigurationChanges = ConfigChanges.ScreenSize | Android.Content.PM.ConfigChanges.Orientation, ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
    public class Timraunho : Activity
    {
        MediaPlayer _playerBCC1;
        MediaPlayer chonsai;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Timraunho);
            _playerBCC1 = MediaPlayer.Create(this, Resource.Raw.chonraunho);
            _playerBCC1.Start();

            var Stop1 = FindViewById<ImageButton>(Resource.Id.imgexit);
            Stop1.Click += Stop1_Click;

            var caixanhmax = FindViewById<ImageButton>(Resource.Id.caixanhmax);
            var caixanhmin = FindViewById<ImageButton>(Resource.Id.caixanhmin);
            var caitimmax = FindViewById<ImageButton>(Resource.Id.caitimmax);
            var caitimmin = FindViewById<ImageButton>(Resource.Id.caitimmin);
            var caitim = FindViewById<ImageButton>(Resource.Id.caitim);
            var xalachmax = FindViewById<ImageButton>(Resource.Id.xalachmax);
            var xalachmin = FindViewById<ImageButton>(Resource.Id.xalachmin);
            var xalach= FindViewById<ImageButton>(Resource.Id.xalach);
            
            caitimmax.Visibility = ViewStates.Invisible;
            caitimmin.Visibility = ViewStates.Invisible;
            caitim.Visibility = ViewStates.Invisible;
            xalachmax.Visibility = ViewStates.Invisible;
            xalachmin.Visibility = ViewStates.Invisible;
            xalach.Visibility = ViewStates.Invisible;
            // chon sai
            caixanhmax.Click += delegate
            {
                chonsai = MediaPlayer.Create(this, Resource.Raw.chonsai_1);
                chonsai.Start();
            };
            caixanhmax.Click += delegate
            {
                chonsai = MediaPlayer.Create(this, Resource.Raw.chonsai_1);
                chonsai.Start();
            };
            caitim.Click += delegate
            {
                chonsai = MediaPlayer.Create(this, Resource.Raw.chonsai_1);
                chonsai.Start();
            };
            caitimmax.Click += delegate
            {
                chonsai = MediaPlayer.Create(this, Resource.Raw.chonsai_1);
                chonsai.Start();
            };
            xalach.Click += delegate
            {
                chonsai = MediaPlayer.Create(this, Resource.Raw.chonsai_1);
                chonsai.Start();
            };
            xalachmax.Click += delegate
            {
                chonsai = MediaPlayer.Create(this, Resource.Raw.chonsai_1);
                chonsai.Start();
            };

            // chon dung

            caitimmin.Click += delegate
            {
                Animation xoay = AnimationUtils.LoadAnimation(this, Resource.Animation.xoay);
                caitimmin.StartAnimation(xoay);
                caitimmin.Visibility = ViewStates.Invisible;
                Handler h = new Handler();
                Action myAction = () =>
                {

                    xalachmax.Visibility = ViewStates.Visible;
                    xalachmin.Visibility = ViewStates.Visible;
                    xalach.Visibility = ViewStates.Visible;
                    caitimmax.Visibility = ViewStates.Invisible;
                    caitim.Visibility = ViewStates.Invisible;
                };

                h.PostDelayed(myAction, 2000);

            };
            caixanhmin.Click += delegate
            {
                Animation xoay = AnimationUtils.LoadAnimation(this, Resource.Animation.xoay);
                caixanhmin.StartAnimation(xoay);
                caixanhmin.Visibility = ViewStates.Invisible;
                Handler h = new Handler();
                Action myAction = () =>
                {

                    caitimmax.Visibility = ViewStates.Visible;
                    caitimmin.Visibility = ViewStates.Visible;
                    caitim.Visibility = ViewStates.Visible;
                    caixanhmax.Visibility = ViewStates.Invisible;
                };

                h.PostDelayed(myAction, 2000);

            };

            xalachmin.Click += delegate
            {
                Animation xoay = AnimationUtils.LoadAnimation(this, Resource.Animation.xoay);
                xalachmin.StartAnimation(xoay);
                xalachmin.Visibility = ViewStates.Invisible;
                Handler h = new Handler();
                Action myAction = () =>
                {
                    // your code that you want to delay here
                    {

                        FragmentTransaction ft = FragmentManager.BeginTransaction();
                        //Remove fragment else it will crash as it is already added to backstack
                        Fragment prev = FragmentManager.FindFragmentByTag("dialog");
                        if (prev != null)
                        {
                            ft.Remove(prev);
                        }
                        ft.AddToBackStack(null);
                        // Create and show the dialog.
                        dialog newFragment = dialog.NewInstance(null);
                        //Add fragment
                        newFragment.Show(ft, "dialog");
                    };

                };

                h.PostDelayed(myAction, 2000);

            };


        }
        void Stop1_Click(object sender, EventArgs e)
        {

            Intent intent = new Intent(this, typeof(MainActivity));
            this.StartActivity(intent);
        }

    }
}






