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
using System.IO;
using System.Timers;
namespace Start
{
    [Activity(ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize | Android.Content.PM.ConfigChanges.Orientation, ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
    public class S1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.S1);
            var mhph1 = FindViewById<ImageView>(Resource.Id.hinhnen);
            var cho = FindViewById<ImageView>(Resource.Id.dophin);
            var tajcho = FindViewById<ImageView>(Resource.Id.taj);
             

            var soluong = FindViewById<ImageButton>(Resource.Id.btsoluong);
            soluong.Click += Soluong_Click;
            var sosanh = FindViewById<ImageButton>(Resource.Id.btsosanh);
            sosanh.Click += Sosanh_Click;
            var thembot = FindViewById<ImageButton>(Resource.Id.btthembot);
            thembot.Click += Thembot_Click;

            var quayve = FindViewById<ImageButton>(Resource.Id.imgquayve);
            quayve.Click += Stop_Click;

            soluong.Visibility = ViewStates.Invisible;
            sosanh.Visibility = ViewStates.Invisible;
            thembot.Visibility = ViewStates.Invisible;
            cho.Visibility = ViewStates.Invisible;
            tajcho.Visibility = ViewStates.Invisible;

            Handler h = new Handler();
            Action myAction = () =>
            {
                thembot.Visibility = ViewStates.Visible;
                sosanh.Visibility = ViewStates.Visible;
                soluong.Visibility = ViewStates.Visible;
                cho.Visibility = ViewStates.Visible;
                tajcho.Visibility = ViewStates.Visible;
                mhph1.Visibility = ViewStates.Invisible;

            };

            h.PostDelayed(myAction, 2000);
           

        }
        void Soluong_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(S1_gioithieu));
            this.StartActivity(intent);
            this.Finish();
        }
        void Sosanh_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(S1_ssbang));
            this.StartActivity(intent);
            this.Finish();
        }
        void Thembot_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(S1_gop));
            this.StartActivity(intent);
            this.Finish();
        }
        void Stop_Click(object sender, EventArgs e)
        {

            Intent intent = new Intent(this, typeof(MainActivity));
            this.StartActivity(intent);
            this.Finish();
        }

    }
}