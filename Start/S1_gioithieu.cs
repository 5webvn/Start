using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    public class S1_gioithieu : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.S1_gioithieu);

            //animation
            Animation nhay = AnimationUtils.LoadAnimation(this, Resource.Animation.nhay);

            // khai bao so
            var somot= FindViewById<ImageView>(Resource.Id.somot);
            var sohai = FindViewById<ImageView>(Resource.Id.sohai);
            var soba= FindViewById<ImageView>(Resource.Id.soba);
            var sobon = FindViewById<ImageView>(Resource.Id.sobon);
            var sonam = FindViewById<ImageView>(Resource.Id.sonam);
            var sosau = FindViewById<ImageView>(Resource.Id.sosau);
            var sobay = FindViewById<ImageView>(Resource.Id.sobay);
            var sotam = FindViewById<ImageView>(Resource.Id.sotam);
            var sochin = FindViewById<ImageView>(Resource.Id.sochin);
            var somuoi = FindViewById<ImageView>(Resource.Id.somuoi);

          
            sohai.Visibility = ViewStates.Invisible;
            soba.Visibility = ViewStates.Invisible;
            sobon.Visibility = ViewStates.Invisible;
            sonam.Visibility = ViewStates.Invisible;
            sosau.Visibility = ViewStates.Invisible;
            sobay.Visibility = ViewStates.Invisible;
            sotam.Visibility = ViewStates.Invisible;
            sochin.Visibility = ViewStates.Invisible;
            somuoi.Visibility = ViewStates.Invisible;

            // khai bao dau
            var dau1 = FindViewById<ImageView>(Resource.Id.dau1);
            var dau2 = FindViewById<ImageView>(Resource.Id.dau2);
            var dau3 = FindViewById<ImageView>(Resource.Id.dau3);
            var dau4 = FindViewById<ImageView>(Resource.Id.dau4);
            var dau5 = FindViewById<ImageView>(Resource.Id.dau5);
            var dau6 = FindViewById<ImageView>(Resource.Id.dau6);
            var dau7 = FindViewById<ImageView>(Resource.Id.dau7);
            var dau8 = FindViewById<ImageView>(Resource.Id.dau8);
            var dau9 = FindViewById<ImageView>(Resource.Id.dau9);
            var dau10 = FindViewById<ImageView>(Resource.Id.dau10);


            dau2.Visibility = ViewStates.Invisible;
            dau3.Visibility = ViewStates.Invisible;
            dau4.Visibility = ViewStates.Invisible;
            dau5.Visibility = ViewStates.Invisible;
            dau6.Visibility = ViewStates.Invisible;
            dau7.Visibility = ViewStates.Invisible;
            dau8.Visibility = ViewStates.Invisible;
            dau9.Visibility = ViewStates.Invisible;
            dau10.Visibility = ViewStates.Invisible;

            // khai bao nut play
            var Play = FindViewById<ImageButton>(Resource.Id.ivtiep);
            Play.Click += Play_Click;

            #region gioi thieu so
            somot.Visibility = ViewStates.Visible;
                {
                    dau1.Visibility = ViewStates.Visible;
                
                    Handler h = new Handler();
                    Action myAction = () =>
                    {
                        
                        somot.Visibility = ViewStates.Invisible;
                        sohai.Visibility = ViewStates.Visible;
                        dau2.Visibility = ViewStates.Visible;

                    };

                    h.PostDelayed(myAction, 4000);

                };
             sohai.Visibility = ViewStates.Invisible;
              {

                Handler h = new Handler();
                Action myAction = () =>
                {
                    sohai.Visibility = ViewStates.Invisible;
                    dau3.Visibility = ViewStates.Visible;
                    soba.Visibility = ViewStates.Visible;
                };

                h.PostDelayed(myAction, 8000);

            };
            soba.Visibility = ViewStates.Invisible;
            {

                Handler h = new Handler();
                Action myAction = () =>
                {
                    soba.Visibility = ViewStates.Invisible;
                    dau4.Visibility = ViewStates.Visible;
                    sobon.Visibility = ViewStates.Visible;
                };

                h.PostDelayed(myAction, 12000);

            };
            sobon.Visibility = ViewStates.Invisible;
            {

                Handler h = new Handler();
                Action myAction = () =>
                {
                    sobon.Visibility = ViewStates.Invisible;
                    dau5.Visibility = ViewStates.Visible;
                    sonam.Visibility = ViewStates.Visible;
                };

                h.PostDelayed(myAction, 16000);

            };
            sonam.Visibility = ViewStates.Invisible;
            {

                Handler h = new Handler();
                Action myAction = () =>
                {
                    sonam.Visibility = ViewStates.Invisible;
                    dau6.Visibility = ViewStates.Visible;
                    sosau.Visibility = ViewStates.Visible;
                };

                h.PostDelayed(myAction, 20000);

            };
            sosau.Visibility = ViewStates.Invisible;
            {

                Handler h = new Handler();
                Action myAction = () =>
                {
                    sosau.Visibility = ViewStates.Invisible;
                    dau7.Visibility = ViewStates.Visible;
                    sobay.Visibility = ViewStates.Visible;
                };

                h.PostDelayed(myAction, 24000);

            };
            sobay.Visibility = ViewStates.Invisible;
            {

                Handler h = new Handler();
                Action myAction = () =>
                {
                    sobay.Visibility = ViewStates.Invisible;
                    dau8.Visibility = ViewStates.Visible;
                    sotam.Visibility = ViewStates.Visible;
                };

                h.PostDelayed(myAction, 28000);

            };
            sotam.Visibility = ViewStates.Invisible;
            {

                Handler h = new Handler();
                Action myAction = () =>
                {
                    sotam.Visibility = ViewStates.Invisible;
                    dau9.Visibility = ViewStates.Visible;
                    sochin.Visibility = ViewStates.Visible;
                };

                h.PostDelayed(myAction, 32000);

            };
            sochin.Visibility = ViewStates.Invisible;
            {

                Handler h = new Handler();
                Action myAction = () =>
                {
                    sochin.Visibility = ViewStates.Invisible;
                    dau10.Visibility = ViewStates.Visible;
                    somuoi.Visibility = ViewStates.Visible;
                };

                h.PostDelayed(myAction, 36000);

            };
            #endregion 

         }
        void Play_Click(object sender, EventArgs e)
        {

            Intent intent = new Intent(this, typeof(S1_chonso01));
            
            this.StartActivity(intent);
            this.Finish();
        }
    }
}