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
    public class S1_chonso0 : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.S1_chonso02);

            var sosau = FindViewById<ImageButton>(Resource.Id.sosau);
            var sobay = FindViewById<ImageButton>(Resource.Id.sobay);
            var sotam = FindViewById<ImageButton>(Resource.Id.sotam);
            var sochin = FindViewById<ImageButton>(Resource.Id.sochin);
            var somuoi = FindViewById<ImageButton>(Resource.Id.somuoi);

            var dia6 = FindViewById<ImageButton>(Resource.Id.dia6);
            var dia7 = FindViewById<ImageButton>(Resource.Id.dia7);
            var dia8 = FindViewById<ImageButton>(Resource.Id.dia8);
            var dia9 = FindViewById<ImageButton>(Resource.Id.dia9);
            var dia10 = FindViewById<ImageButton>(Resource.Id.dia10);
            Animation xoay = AnimationUtils.LoadAnimation(this, Resource.Animation.xoay);

            #region  so va dia cung click

            sosau.Click += (sender, ea) =>
            {
                sosau.StartAnimation(xoay);

                dia6.Click += delegate
                {
                    sosau.StartAnimation(xoay);
                    dia6.StartAnimation(xoay);
                    Handler h = new Handler();
                    Action myAction = () =>
                    {
                        sosau.Visibility = ViewStates.Invisible;
                        dia6.Visibility = ViewStates.Invisible;
                    };

                    h.PostDelayed(myAction, 2000);
                };
            };

            sobay.Click += (sender, ea) =>
            {

                sobay.StartAnimation(xoay);
                dia7.Click += delegate
                {
                    sobay.StartAnimation(xoay);
                    dia7.StartAnimation(xoay);
                    Handler h = new Handler();
                    Action myAction = () =>
                    {
                        sobay.Visibility = ViewStates.Invisible;
                        dia7.Visibility = ViewStates.Invisible;
                    };

                    h.PostDelayed(myAction, 2000);
                };
            };

            sotam.Click += (sender, ea) =>
            {
                sotam.StartAnimation(xoay);
                dia8.Click += delegate
                {
                    sotam.StartAnimation(xoay);
                    dia8.StartAnimation(xoay);
                    Handler h = new Handler();
                    Action myAction = () =>
                    {
                        sotam.Visibility = ViewStates.Invisible;
                        dia8.Visibility = ViewStates.Invisible;
                    };

                    h.PostDelayed(myAction, 2000);
                };
            };
            sochin.Click += (sender, ea) =>
            {
                sochin.StartAnimation(xoay);
                dia9.Click += delegate
                {
                    sochin.StartAnimation(xoay);
                    dia9.StartAnimation(xoay);
                    Handler h = new Handler();
                    Action myAction = () =>
                    {
                        sochin.Visibility = ViewStates.Invisible;
                        dia9.Visibility = ViewStates.Invisible;
                    };

                    h.PostDelayed(myAction, 2000);
                };
            };
            somuoi.Click += (sender, ea) =>
            {
                dia10.Click += delegate
                {
                    somuoi.StartAnimation(xoay);
                    dia10.StartAnimation(xoay);
                    Handler h = new Handler();
                    Action myAction = () =>
                    {
                        somuoi.Visibility = ViewStates.Invisible;
                        dia10.Visibility = ViewStates.Invisible;
                    };

                    h.PostDelayed(myAction, 2000);
                };
            };
            #endregion

        }



    }

}