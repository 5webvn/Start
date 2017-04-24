
using System;
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
	[Activity(MainLauncher = true, Icon = "@drawable/icon", ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize | Android.Content.PM.ConfigChanges.Orientation, ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape)]
	public class SplashScreen : Activity
	{
		
		private ProgressBar progressBar;



		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.SplashScreen);
			progressBar = FindViewById<ProgressBar>(Resource.Id.progressBar);

			

			//Wait for 3 seconds and start new Activity
			Timer timer = new Timer();
			timer.Interval = 3000;
			timer.AutoReset = false;
			timer.Elapsed += Timer_Elapsed;
			timer.Start();
		}

		private void Timer_Elapsed(object sender, ElapsedEventArgs e)
		{
			StartActivity(new Intent(this, typeof(MainActivity)));
		}

		}
	}
