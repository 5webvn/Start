﻿using System;
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
    public class caohonthaphon : Activity
    {
        MediaPlayer _playerBCC;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.caohonthaphon);

            _playerBCC = MediaPlayer.Create(this, Resource.Raw.caothap);
            _playerBCC.Start();

            ImageView namcao = FindViewById<ImageView>(Resource.Id.namcao);
            ImageView namthap = FindViewById<ImageView>(Resource.Id.namthap);
            Animation nhay = AnimationUtils.LoadAnimation(this, Resource.Animation.nhay);
            namcao.StartAnimation(nhay);

            Animation nhay1 = AnimationUtils.LoadAnimation(this, Resource.Animation.nhay1);
            namthap.StartAnimation(nhay1);

            var play = FindViewById<ImageButton>(Resource.Id.ivplay);
            play.Click += play_Click;


        }
        void play_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(timcaycao));
            this.StartActivity(intent);

        }

    }
}
