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
    public class S1_chonso : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.S1_chonso);
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

        }
        void playbtn_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(S1_chonso01));
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