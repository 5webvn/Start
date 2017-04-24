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
    [Activity(ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize | Android.Content.PM.ConfigChanges.Orientation, ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
    public class timcaycao : Activity
    {
        MediaPlayer _timcaycao;
        MediaPlayer _timcaythap;
        MediaPlayer _timchuchuot;
        MediaPlayer _timcaycaonhat;
        //MediaPlayer chonsai;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.timcaycao);
            //khaibaotimcaycao1
            var ivcaycao = FindViewById<ImageView>(Resource.Id.ivcaycao);
            var ivcaythap = FindViewById<ImageView>(Resource.Id.ivcaythap);
            //khaibao tim cay thap
            var ivcanhcao = FindViewById<ImageView>(Resource.Id.ivcanhcao);
            var ivcanhvua = FindViewById<ImageView>(Resource.Id.ivcanhvua);
            var ivcanhthap = FindViewById<ImageView>(Resource.Id.ivcanhthap);
            ivcanhcao.Visibility = ViewStates.Invisible;
            ivcanhthap.Visibility = ViewStates.Invisible;
            ivcanhvua.Visibility = ViewStates.Invisible;
           

            //khai bao tim chuot
            var ivcayc = FindViewById<ImageView>(Resource.Id.ivcayc);
            var ivcayv = FindViewById<ImageView>(Resource.Id.ivcayv);
            var ivcayt = FindViewById<ImageView>(Resource.Id.ivcayt);
            ivcayc.Visibility = ViewStates.Invisible;
            ivcayv.Visibility = ViewStates.Invisible;
            ivcayt.Visibility = ViewStates.Invisible;

            //am thanh tim cay cao
            _timcaycao = MediaPlayer.Create(this, Resource.Raw.timcaycao);
            _timcaycao.Start();
            // chon cay cao
            ivcaycao.Click += delegate
            {
                _timcaycao.Stop();
                Animation xoay = AnimationUtils.LoadAnimation(this, Resource.Animation.xoay);
                ivcaycao.StartAnimation(xoay);
                ivcaycao.Visibility = ViewStates.Invisible;
                Handler h = new Handler();
                Action myAction = () =>
                {

                    ivcanhcao.Visibility = ViewStates.Visible;
                    ivcanhthap.Visibility = ViewStates.Visible;
                    ivcanhvua.Visibility = ViewStates.Visible;
                    ivcaythap.Visibility = ViewStates.Invisible;
                    _timcaythap = MediaPlayer.Create(this, Resource.Raw.timcaythap);
                    _timcaythap.Start();

                };

                h.PostDelayed(myAction, 2000);

            };
            ivcanhthap.Click += delegate
            {
                _timcaythap.Stop();
                Animation xoay = AnimationUtils.LoadAnimation(this, Resource.Animation.xoay);
                ivcanhthap.StartAnimation(xoay);
                ivcanhthap.Visibility = ViewStates.Invisible;
                Handler h = new Handler();
                Action myAction = () =>
                {

                    ivcayc.Visibility = ViewStates.Visible;
                    ivcayt.Visibility = ViewStates.Visible;
                    ivcayv.Visibility = ViewStates.Visible;
                    ivcanhcao.Visibility = ViewStates.Invisible;
                    ivcanhvua.Visibility = ViewStates.Invisible;
                    _timchuchuot = MediaPlayer.Create(this, Resource.Raw.timchuchuot);
                    _timchuchuot.Start();

                };

                h.PostDelayed(myAction, 2000);

            };
            ivcayt.Click += delegate
            {
                _timchuchuot.Stop();
                Animation xoay = AnimationUtils.LoadAnimation(this, Resource.Animation.xoay);
                ivcayt.StartAnimation(xoay);
                ivcayt.Visibility = ViewStates.Invisible;
                Handler h = new Handler();
                Action myAction = () =>
                {

                    ivcanhcao.Visibility = ViewStates.Visible;
                    ivcanhthap.Visibility = ViewStates.Visible;
                    ivcanhvua.Visibility = ViewStates.Visible;
                    ivcayv.Visibility = ViewStates.Invisible;
                    ivcayc.Visibility = ViewStates.Invisible;
                    _timcaycaonhat = MediaPlayer.Create(this, Resource.Raw.timcaycao2);
                    _timcaycaonhat.Start();

                };

                h.PostDelayed(myAction, 2000);

            };

            ivcanhcao.Click += delegate
            {
                _timcaycaonhat.Stop();
                Animation xoay = AnimationUtils.LoadAnimation(this, Resource.Animation.xoay);
                ivcanhcao.StartAnimation(xoay);
                ivcanhcao.Visibility = ViewStates.Invisible;
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
                        Dialog2 newFragment = Dialog2.NewInstance(null);
                        //Add fragment
                        newFragment.Show(ft, "dialog");
                    };
                };
                    h.PostDelayed(myAction, 2000);

                };
                    

       

         }
         
    }
}