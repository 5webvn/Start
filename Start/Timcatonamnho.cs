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
    [Activity(ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize | Android.Content.PM.ConfigChanges.Orientation, ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
    public class Timcatonamnho : Activity
    {
        MediaPlayer _playerBCC;
        MediaPlayer chonsai;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Timcatonamnho);

            _playerBCC = MediaPlayer.Create(this, Resource.Raw.choncanam);
            _playerBCC.Start();

            var Stop = FindViewById<ImageButton>(Resource.Id.imgexit);
            Stop.Click += Stop_Click;

            var camax = FindViewById<ImageButton>(Resource.Id.camax);
            var camax1 = FindViewById<ImageButton>(Resource.Id.camax1);
            var camin1 = FindViewById<ImageButton>(Resource.Id.camin1);
            var camin2 = FindViewById<ImageButton>(Resource.Id.cammin2);
            var nammax = FindViewById<ImageButton>(Resource.Id.Nammax);
            var nammax1 = FindViewById<ImageButton>(Resource.Id.Nammax1);
            var nammin = FindViewById<ImageButton>(Resource.Id.Nammin);
            var nammin1 = FindViewById<ImageButton>(Resource.Id.Nammin1);

            //chon sai
            camax1.Click += delegate
            {
                chonsai = MediaPlayer.Create(this, Resource.Raw.chonsai_1);
                chonsai.Start();
            };
            camin1.Click += delegate
            {
                chonsai = MediaPlayer.Create(this, Resource.Raw.chonsai_1);
                chonsai.Start();
            };
            camin2.Click += delegate
            {
                chonsai = MediaPlayer.Create(this, Resource.Raw.chonsai_1);
                chonsai.Start();
            };
            nammin1.Click += delegate
            {
                chonsai = MediaPlayer.Create(this, Resource.Raw.chonsai_1);
                chonsai.Start();
            };
            nammax1.Click += delegate
            {
                chonsai = MediaPlayer.Create(this, Resource.Raw.chonsai_1);
                chonsai.Start();
            };
            nammax.Click += delegate
            {
                chonsai = MediaPlayer.Create(this, Resource.Raw.chonsai_1);
                chonsai.Start();
            };


            // chon dung
            camax.Click += delegate
            {
                Animation xoay = AnimationUtils.LoadAnimation(this, Resource.Animation.xoay);
                camax.StartAnimation(xoay);
                camax.Visibility = ViewStates.Invisible;
                

            };
            nammin.Click += delegate
            {
                Animation xoay = AnimationUtils.LoadAnimation(this, Resource.Animation.xoay);
                nammin.StartAnimation(xoay);
                nammin.Visibility = ViewStates.Invisible;
                Handler h = new Handler();
                Action myAction = () =>
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
                    dialog1 newFragment = dialog1.NewInstance(null);
                    //Add fragment
                    newFragment.Show(ft, "dialog");

                };

                h.PostDelayed(myAction, 2000);

            };

           

        }
        void Stop_Click(object sender, EventArgs e)
        {

            Intent intent = new Intent(this, typeof(MainActivity));
            this.StartActivity(intent);
        }


    }
}






