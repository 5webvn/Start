using System;
using Android.Content;
using Android.Runtime;
using Android.App;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Widget;
using Android.Views.Animations;
using Android.Views;


namespace Start
{
    [Activity(ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize | Android.Content.PM.ConfigChanges.Orientation, ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
    public class Story : Activity
	{
		AnimationDrawable animation;
		ImageView imageView;
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Story);
			var imgbt1 = FindViewById<ImageButton>(Resource.Id.ivtiep);
            var imgbtnha = FindViewById<ImageButton>(Resource.Id.ivnha);
            var imgbtvuon = FindViewById<ImageButton>(Resource.Id.ivvuon);
            var imgbtrung = FindViewById<ImageButton>(Resource.Id.ivrung);
            var imgbtkb = FindViewById<ImageButton>(Resource.Id.ivkhobau);
            imgbtnha.Visibility = ViewStates.Invisible;
            imgbtvuon.Visibility = ViewStates.Invisible;
            imgbtrung.Visibility = ViewStates.Invisible;
            imgbtkb.Visibility = ViewStates.Invisible;
            imgbt1.Click += delegate {
                imageView.Visibility = ViewStates.Invisible;
                imgbt1.Visibility = ViewStates.Invisible;
                imgbtnha.Visibility = ViewStates.Visible;
                imgbtvuon.Visibility = ViewStates.Visible;
                imgbtrung.Visibility = ViewStates.Visible;
                imgbtkb.Visibility = ViewStates.Visible;
            };
            // button phan he 3
            var S3 = FindViewById<ImageButton>(Resource.Id.ivrung);
            S3.Click += S3_Click;
            //button phan he 1
            var S1 = FindViewById<ImageButton>(Resource.Id.ivnha);
            S1.Click += S1_Click;

        }

		public override void OnWindowFocusChanged(bool hasFocus)
		{
			if (hasFocus)
			{
				imageView = FindViewById<ImageView>(Resource.Id.animated_android);
				animation = (AnimationDrawable)imageView.Drawable;
				animation.Start();
			}
		}
		protected override void OnDestroy()
		{
			base.OnDestroy();
			animation.Stop();
			imageView.SetImageDrawable(null);
		}
        void S3_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(S3));
            this.StartActivity(intent);

        }
        void S1_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this, typeof(S1));
            this.StartActivity(intent);

        }

    }
}