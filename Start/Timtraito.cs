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
    public class Timtraito : Activity
    {
        MediaPlayer _playerBCC;
        MediaPlayer chonsai;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Timtraito);
            _playerBCC = MediaPlayer.Create(this, Resource.Raw.chonquato);
            _playerBCC.Start();

            var Stop = FindViewById<ImageButton>(Resource.Id.imgexit);
            Stop.Click += Stop_Click;

            var cachuaTo = FindViewById<ImageButton>(Resource.Id.cachuaTo);
            var cachuanho = FindViewById<ImageButton>(Resource.Id.cachuaNho);
            var nhomax = FindViewById<ImageButton>(Resource.Id.nhomax);
            var nhomin = FindViewById<ImageButton>(Resource.Id.nhomin);
            var nho = FindViewById<ImageButton>(Resource.Id.nho);
            var duamax = FindViewById<ImageButton>(Resource.Id.duamax);
            var duamin = FindViewById<ImageButton>(Resource.Id.duamin);
            var dua = FindViewById<ImageButton>(Resource.Id.dua);

            nhomax.Visibility = ViewStates.Invisible;
            nhomin.Visibility = ViewStates.Invisible;
            nho.Visibility = ViewStates.Invisible;
            duamax.Visibility = ViewStates.Invisible;
            duamin.Visibility = ViewStates.Invisible;
            dua.Visibility = ViewStates.Invisible;

            // chon sai
            cachuanho.Click += delegate
            {
                chonsai = MediaPlayer.Create(this, Resource.Raw.chonsai_1);
                chonsai.Start();
            };
            nhomin.Click += delegate
            {
                chonsai = MediaPlayer.Create(this, Resource.Raw.chonsai_1);
                chonsai.Start();
            };
            nho.Click += delegate
            {
                chonsai = MediaPlayer.Create(this, Resource.Raw.chonsai_1);
                chonsai.Start();
            };
            duamin.Click += delegate
            {
                chonsai = MediaPlayer.Create(this, Resource.Raw.chonsai_1);
                chonsai.Start();
            };
            dua.Click += delegate
            {
                chonsai = MediaPlayer.Create(this, Resource.Raw.chonsai_1);
                chonsai.Start();
            };
            // chon dung
            nhomax.Click += delegate
            {
                Animation xoay = AnimationUtils.LoadAnimation(this, Resource.Animation.xoay);
                nhomax.StartAnimation(xoay);
                nhomax.Visibility = ViewStates.Invisible;
                Handler h = new Handler();
                Action myAction = () =>
                {

                    duamax.Visibility = ViewStates.Visible;
                    duamin.Visibility = ViewStates.Visible;
                    dua.Visibility = ViewStates.Visible;
                    nhomin.Visibility = ViewStates.Invisible;
                    nho.Visibility = ViewStates.Invisible;
                };

                h.PostDelayed(myAction, 2000);

            };
            cachuaTo.Click += delegate
            {
                Animation xoay = AnimationUtils.LoadAnimation(this, Resource.Animation.xoay);
                cachuaTo.StartAnimation(xoay);
                cachuaTo.Visibility = ViewStates.Invisible;
                Handler h = new Handler();
                Action myAction = () =>
                {

                    nhomax.Visibility = ViewStates.Visible;
                    nhomin.Visibility = ViewStates.Visible;
                    nho.Visibility = ViewStates.Visible;
                    cachuanho.Visibility = ViewStates.Invisible;
                };

                h.PostDelayed(myAction, 2000);

            };


            duamax.Click += delegate
            {
                Animation xoay = AnimationUtils.LoadAnimation(this, Resource.Animation.xoay);
                duamax.StartAnimation(xoay);
                duamax.Visibility = ViewStates.Invisible;
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
                        DialogFragment1 newFragment = DialogFragment1.NewInstance(null);
                        //Add fragment
                        newFragment.Show(ft, "dialog");
                    };

                };

                h.PostDelayed(myAction, 2000);

            };


        }
        void Stop_Click(object sender, EventArgs e)
        {

            Intent intent = new Intent(this, typeof(S3));
            this.StartActivity(intent);
        }



    }
}






