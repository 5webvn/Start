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
    public class dialog1 : DialogFragment
    {
        public static dialog1 NewInstance(Bundle bundle)
        {
            dialog1 fragment = new dialog1();
            fragment.Arguments = bundle;
            return fragment;
        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View view = inflater.Inflate(Resource.Layout.dialog, container, false);
            ImageButton quaylai = view.FindViewById<ImageButton>(Resource.Id.choilai);
            quaylai.Click += delegate {
                Dismiss();
                //Toast.(Activity, "Dialog fragment dismissed!", ToastLength.Short).Show();
                var intent = new Intent(this.Activity, typeof(Timcatonamnho));
                this.StartActivity(intent);

            };
            ImageButton quaman1 = view.FindViewById<ImageButton>(Resource.Id.quaman);
            quaman1.Click += delegate
            {

                Dismiss();
                //Toast.(Activity, "Dialog fragment dismissed!", ToastLength.Short).Show();
                var intent = new Intent(this.Activity, typeof(S3_voi));
                this.StartActivity(intent);

            };
            return view;
        }
    }
}