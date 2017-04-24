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
using Android.Media;
using Android.Animation;
using Android.Views.Animations;

namespace Start
{
    [Activity(ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize | Android.Content.PM.ConfigChanges.Orientation, ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
    public class S3_voi : Activity
    {
        MediaPlayer _playerBCC;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.S3_voi);

            _playerBCC = MediaPlayer.Create(this, Resource.Raw.voi);
            _playerBCC.Start();

            ImageView Voi = FindViewById<ImageView>(Resource.Id.voi);
            ImageView Voi1 = FindViewById<ImageView>(Resource.Id.voi1);
            ImageView TaJ = FindViewById<ImageView>(Resource.Id.taj);
            ImageView TaJ1= FindViewById<ImageView>(Resource.Id.taj1);
            ImageButton ivran = FindViewById<ImageButton>(Resource.Id.ivran);
            ImageButton ivnai = FindViewById<ImageButton>(Resource.Id.ivnai);
            ImageButton ivcu = FindViewById<ImageButton>(Resource.Id.ivcu);
            ImageButton ivtiep = FindViewById<ImageButton>(Resource.Id.ivtiep);
            ImageButton ivquayve = FindViewById<ImageButton>(Resource.Id.ivquayve);

            
            TaJ1.Visibility = ViewStates.Invisible;
            Voi1.Visibility = ViewStates.Invisible;
            ivcu.Visibility = ViewStates.Invisible;
            ivnai.Visibility = ViewStates.Invisible;
            ivran.Visibility = ViewStates.Invisible;


            Animation Zoom = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom);
            Voi.StartAnimation(Zoom);

            Animation Zoom1 = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom1);
            TaJ.StartAnimation(Zoom1);
            
            var next = FindViewById<ImageButton>(Resource.Id.ivtiep);
            next.Click += delegate
            {
                _playerBCC.Stop();
                Voi.ClearAnimation();
                TaJ.ClearAnimation();

                Voi.Visibility = ViewStates.Invisible;
                TaJ.Visibility = ViewStates.Invisible;
                ivtiep.Visibility = ViewStates.Invisible;
                Voi1.Visibility = ViewStates.Visible;
                TaJ1.Visibility = ViewStates.Visible;
                ivran.Visibility = ViewStates.Visible;
                ivcu.Visibility = ViewStates.Visible;
                ivnai.Visibility = ViewStates.Visible;
            };

            ivnai.Click += Ivnai_Click;
            ivran.Click += Ivran_Click;
            ivcu.Click += Ivcu_Click;
            ivquayve.Click += Ivquayve_Click;

        }

         void Ivnai_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(S3_nai));
            this.StartActivity(intent);
        }
        void Ivcu_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(S3_cu));
            this.StartActivity(intent);
        }
        void Ivran_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(S3_ran));
            this.StartActivity(intent);
        }

        void Ivquayve_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(S3));
            this.StartActivity(intent);
        }


    }
}
