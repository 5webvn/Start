using System;
using Android.App;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Views.Animations;
using Android.Content.PM;
using Android.Media;
using Android.Content;
using Java.Lang;


namespace Start
{
    [Activity(ConfigurationChanges = ConfigChanges.ScreenSize | Android.Content.PM.ConfigChanges.Orientation, ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
    public class S1_chonso01 : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.S1_chonso01);

            var somot = FindViewById<ImageButton>(Resource.Id.somot);
            var sohai = FindViewById<ImageButton>(Resource.Id.sohai);
            var soba = FindViewById<ImageButton>(Resource.Id.soba);
            var sobon = FindViewById<ImageButton>(Resource.Id.sobon);
            var sonam = FindViewById<ImageButton>(Resource.Id.sonam);

            var dia1 = FindViewById<ImageButton>(Resource.Id.dia1);
            var dia2 = FindViewById<ImageButton>(Resource.Id.dia2);
            var dia3 = FindViewById<ImageButton>(Resource.Id.dia3);
            var dia4 = FindViewById<ImageButton>(Resource.Id.dia4);
            var dia5 = FindViewById<ImageButton>(Resource.Id.dia5);
            Animation xoay = AnimationUtils.LoadAnimation(this, Resource.Animation.xoay);


            #region  so va dia cung click



            somot.Click += (sender, ea) =>
            {
                somot.StartAnimation(xoay);
                somot.Click += delegate
                 {
                     somot.StartAnimation(xoay);
                     dia1.StartAnimation(xoay);
                     Handler h = new Handler();
                     Action myAction = () =>
                     {
                         somot.Visibility = ViewStates.Invisible;
                         dia1.Visibility = ViewStates.Invisible;
                     };

                     h.PostDelayed(myAction, 2000);
                 };
            };

            sohai.Click += (sender, ea) =>
            {

                sohai.StartAnimation(xoay);
                dia2.Click += delegate
                {
                    sohai.StartAnimation(xoay);
                    dia2.StartAnimation(xoay);
                    Handler h = new Handler();
                    Action myAction = () =>
                    {
                        sohai.Visibility = ViewStates.Invisible;
                        dia2.Visibility = ViewStates.Invisible;
                    };

                    h.PostDelayed(myAction, 2000);
                };
            };

            soba.Click += (sender, ea) =>
            {
                soba.StartAnimation(xoay);
                dia3.Click += delegate
                {
                    soba.StartAnimation(xoay);
                    dia3.StartAnimation(xoay);
                    Handler h = new Handler();
                    Action myAction = () =>
                    {
                        soba.Visibility = ViewStates.Invisible;
                        dia3.Visibility = ViewStates.Invisible;
                    };

                    h.PostDelayed(myAction, 2000);
                };
            };
            sobon.Click += (sender, ea) =>
            {
                sobon.StartAnimation(xoay);
                dia4.Click += delegate
                {
                    sobon.StartAnimation(xoay);
                    dia4.StartAnimation(xoay);
                    Handler h = new Handler();
                    Action myAction = () =>
                    {
                        sobon.Visibility = ViewStates.Invisible;
                        dia4.Visibility = ViewStates.Invisible;
                    };

                    h.PostDelayed(myAction, 2000);
                };
            };
            sonam.Click += (sender, ea) =>
            {
                dia5.Click += delegate
               {
                   sonam.StartAnimation(xoay);
                   dia5.StartAnimation(xoay);
                   Handler h = new Handler();
                   Action myAction = () =>
                   {
                       sonam.Visibility = ViewStates.Invisible;
                       dia5.Visibility = ViewStates.Invisible;
                   };

                   h.PostDelayed(myAction, 2000);
               };
            };
            #endregion





        }             
    
    }

}