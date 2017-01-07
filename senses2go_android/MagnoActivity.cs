
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
using Android.Hardware;

namespace senses2go_android
{
	[Activity(Label = "Erdfeldstärke")]
	public class MagnoActivity : Activity, ISensorEventListener
	{
		SensorManager sensorManager;
		static readonly object _syncLock = new object();

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Magno);

			sensorManager = (SensorManager)GetSystemService(Context.SensorService);
		}

		protected override void OnResume()
		{
			base.OnResume();
			sensorManager.RegisterListener(this,
			                               sensorManager.GetDefaultSensor(SensorType.MagneticField),
											SensorDelay.Ui);
		}

		public void OnAccuracyChanged(Sensor sensor, SensorStatus accuracy)
		{
			// We don't want to do anything here.
		}

		public void OnSensorChanged(SensorEvent e)
		{
			lock (_syncLock)
			{
				FindViewById<TextView>(Resource.Id.textView2).Text = "" + e.Values[0];
				FindViewById<TextView>(Resource.Id.textView4).Text = "" + e.Values[1];
				FindViewById<TextView>(Resource.Id.textView6).Text = "" + e.Values[2];
			}
		}
	}
}
