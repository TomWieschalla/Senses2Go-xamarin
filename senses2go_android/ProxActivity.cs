
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
	[Activity(Label = "Umgebungssensor")]
	public class ProxActivity : Activity, ISensorEventListener
	{
		SensorManager sensorManager;
		static readonly object _syncLock = new object();
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Prox);

			sensorManager = (SensorManager)GetSystemService(Context.SensorService);
		}

		protected override void OnResume()
		{
			base.OnResume();
			sensorManager.RegisterListener(this,
			                               sensorManager.GetDefaultSensor(SensorType.Proximity),
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
			}
		}
	}
}
