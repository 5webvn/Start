
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
namespace Start
{
    [Activity(ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize | Android.Content.PM.ConfigChanges.Orientation, ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
    public class Dialog2 : DialogFragment
    {
        public static Dialog2 NewInstance(Bundle bundle)
        {
            Dialog2 fragment = new Dialog2();
            fragment.Arguments = bundle;
            return fragment;
        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View view = inflater.Inflate(Resource.Layout.dialog, container, false);
            ImageButton choilai1 = view.FindViewById<ImageButton>(Resource.Id.choilai);
            choilai1.Click += delegate {
                Dismiss();
                //Toast.(Activity, "Dialog fragment dismissed!", ToastLength.Short).Show();
                var intent = new Intent(this.Activity, typeof(timcaycao));
                this.StartActivity(intent);

            };
            ImageButton quaman2 = view.FindViewById<ImageButton>(Resource.Id.quaman);
            quaman2.Click += delegate {

                Dismiss();
                //Toast.(Activity, "Dialog fragment dismissed!", ToastLength.Short).Show();
                var intent = new Intent(this.Activity, typeof(S3_voi));
                this.StartActivity(intent);

            };
            return view;
        }
    }
}