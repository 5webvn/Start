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
    public class DialogFragment1 : DialogFragment
    {
        public static DialogFragment1 NewInstance(Bundle bundle)
        {
            DialogFragment1 fragment = new DialogFragment1();
            fragment.Arguments = bundle;
            return fragment;
        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View view = inflater.Inflate(Resource.Layout.dialog, container, false);
            ImageButton choilai = view.FindViewById<ImageButton>(Resource.Id.choilai);
            choilai.Click += delegate {
                Dismiss();
                //Toast.(Activity, "Dialog fragment dismissed!", ToastLength.Short).Show();
                var intent = new Intent(this.Activity, typeof(Timtraito));
                this.StartActivity(intent);
                
            };
            ImageButton quaman = view.FindViewById<ImageButton>(Resource.Id.quaman);
            quaman.Click += delegate {
               
                Dismiss();
                //Toast.(Activity, "Dialog fragment dismissed!", ToastLength.Short).Show();
                var intent = new Intent(this.Activity, typeof(Timraunho));
                this.StartActivity(intent);

            };
            return view;
        }
    }
}