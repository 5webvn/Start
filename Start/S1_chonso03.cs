using System;
using Android.App;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Views.Animations;
using Android.Content;


namespace Start
{
    [Activity(ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize | Android.Content.PM.ConfigChanges.Orientation, ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
    public class S1_chonso03 : Activity
    {
       
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.S1_chonso03);

            var stop = FindViewById<ImageButton>(Resource.Id.imgexit);
            stop.Click += Stop_Click;

            // animation 
            Animation xoay = AnimationUtils.LoadAnimation(this, Resource.Animation.xoay);
            // khai bao so 
            var somot = FindViewById<ImageButton>(Resource.Id.somot);
            var sohai = FindViewById<ImageButton>(Resource.Id.sohai);
            var soba = FindViewById<ImageButton>(Resource.Id.soba);
            var sobon = FindViewById<ImageButton>(Resource.Id.sobon);
            var sonam = FindViewById<ImageButton>(Resource.Id.sonam);
            var sosau = FindViewById<ImageButton>(Resource.Id.sosau);
            var sobay = FindViewById<ImageButton>(Resource.Id.sobay);
            var sotam = FindViewById<ImageButton>(Resource.Id.sotam);
            var sochin = FindViewById<ImageButton>(Resource.Id.sochin);
            var somuoi = FindViewById<ImageButton>(Resource.Id.somuoi);
            // khoi tao va khai bao dia so
            var dia1 = FindViewById<ImageView>(Resource.Id.dia1);
           // var dia2 = FindViewById<ImageButton>(Resource.Drawable.diahai);
            var dia3 = FindViewById<ImageButton>(Resource.Drawable.diaba);
            //var dia4 = FindViewById<ImageButton>(Resource.Drawable.diabon);
            var dia5 = FindViewById<ImageButton>(Resource.Drawable.dianam);
           // var dia6 = FindViewById<ImageButton>(Resource.Drawable.diasau);
            var dia7 = FindViewById<ImageButton>(Resource.Drawable.diabay);
            var dia8 = FindViewById<ImageButton>(Resource.Drawable.diatam);
            var dia9 = FindViewById<ImageButton>(Resource.Drawable.diachin);
           // var dia10 = FindViewById<ImageButton>(Resource.Drawable.diamuoi);
            // an dia so
           // dia2.Visibility = ViewStates.Invisible;
            dia3.Visibility = ViewStates.Invisible;
            //dia4.Visibility = ViewStates.Invisible;
            dia5.Visibility = ViewStates.Invisible;
            //dia6.Visibility = ViewStates.Invisible;
            dia7.Visibility = ViewStates.Invisible;
            dia8.Visibility = ViewStates.Invisible;
            dia9.Visibility = ViewStates.Invisible;
            //dia10.Visibility = ViewStates.Invisible;

            somot.Click += delegate {

                somot.StartAnimation(xoay);
                dia1.StartAnimation(xoay);
                Handler h = new Handler();
                Action myAction = () =>
                {
                    somot.Visibility = ViewStates.Invisible;
                    dia1.Visibility = ViewStates.Visible;
                    dia7.Visibility = ViewStates.Visible;

                };

                h.PostDelayed(myAction, 2000);

            };
            //sobon.Click += delegate {
                
                
            //    Handler h = new Handler();
            //    Action myAction = () =>
            //    {
            //        sobon.Visibility = ViewStates.Invisible;
            //        dia4.Visibility = ViewStates.Invisible;
            //        dia7.Visibility = ViewStates.Visible;

            //    };

            //    h.PostDelayed(myAction, 2000);

            //};
            ////sosau.Click += delegate {


            //    Handler h = new Handler();
            //    Action myAction = () =>
            //    {
            //        sosau.Visibility = ViewStates.Invisible;
            //        dia6.Visibility = ViewStates.Invisible;
            //        dia2.Visibility = ViewStates.Visible;

            //    };

            //    h.PostDelayed(myAction, 2000);

            //};
            sobay.Click += delegate
            {


                Handler h = new Handler();
                Action myAction = () =>
                {
                    sobay.Visibility = ViewStates.Invisible;
                    dia7.Visibility = ViewStates.Invisible;
                    dia9.Visibility = ViewStates.Visible;

                };

                h.PostDelayed(myAction, 2000);

            };

            sotam.Click += delegate {
                
                
                Handler h = new Handler();
                Action myAction = () =>
                {
                    sotam.Visibility = ViewStates.Invisible;
                    dia8.Visibility = ViewStates.Invisible;
                    dia3.Visibility = ViewStates.Visible;

                };

                h.PostDelayed(myAction, 2000);

            };
            soba.Click += delegate {
                
                
                Handler h = new Handler();
                Action myAction = () =>
                {
                    soba.Visibility = ViewStates.Invisible;
                    dia3.Visibility = ViewStates.Invisible;
                    dia5.Visibility = ViewStates.Visible;

                };

                h.PostDelayed(myAction, 2000);

            };
            sonam.Click += delegate {
               
                
                Handler h = new Handler();
                Action myAction = () =>
                {
                    sonam.Visibility = ViewStates.Invisible;
                    dia5.Visibility = ViewStates.Invisible;
                    dia7.Visibility = ViewStates.Visible;

                };

                h.PostDelayed(myAction, 2000);

            };
            sochin.Click += delegate {
                
                sochin.Visibility = ViewStates.Invisible;
                dia9.Visibility = ViewStates.Invisible;
            };
        
         }

        void Stop_Click(object sender, EventArgs e)
          {

            Intent intent = new Intent(this, typeof(MainActivity));
            this.StartActivity(intent);
            this.Finish();
           }
        
       
    }
}








