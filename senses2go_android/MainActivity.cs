using Android.App;
using Android.Widget;
using Android.OS;

namespace senses2go_android
{
	[Activity(Label = "Senses2Go_Xa", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			FindViewById<Button>(Resource.Id.gpsButton).Click += delegate { StartActivity(typeof(GPSActivity)); };
			FindViewById<Button>(Resource.Id.gyroButton).Click += delegate { StartActivity(typeof(GyroActivity)); };
			FindViewById<Button>(Resource.Id.magnoButton).Click += delegate { StartActivity(typeof(MagnoActivity)); };
			FindViewById<Button>(Resource.Id.accButton).Click += delegate { StartActivity(typeof(AccActivity)); };
			FindViewById<Button>(Resource.Id.proxButton).Click += delegate { StartActivity(typeof(ProxActivity)); };
			FindViewById<Button>(Resource.Id.pressureButton).Click += delegate { StartActivity(typeof(PressureActivity)); };
			FindViewById<Button>(Resource.Id.lightButton).Click += delegate { StartActivity(typeof(LightActivity)); };
			FindViewById<Button>(Resource.Id.cameraButton).Click += delegate { StartActivity(typeof(CameraActivity)); };
			FindViewById<Button>(Resource.Id.soundButton).Click += delegate { StartActivity(typeof(SoundActivity)); };
			FindViewById<Button>(Resource.Id.microButton).Click += delegate { StartActivity(typeof(MicroActivity)); };
		}

	}
}

