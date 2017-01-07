
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
using Android.Locations;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;


namespace senses2go_android
{
	[Activity(Label = "GPS Position")]
	public class GPSActivity : Activity, ILocationListener
	{
		LocationManager locMgr;
		GoogleMap map;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.GPS);
			locMgr = GetSystemService(Context.LocationService) as LocationManager;
			MapFragment mapFrag = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.mapView);
			map = mapFrag.Map;
		}

		protected override void OnResume()
		{
			base.OnResume();
			string Provider = LocationManager.GpsProvider;

			if (locMgr.IsProviderEnabled(Provider))
			{
				locMgr.RequestLocationUpdates(Provider, 2000, 1, this);
			}
			else
			{
				/*//set alert for executing the task
				AlertDialog.Builder alert = new AlertDialog.Builder(this);
				alert.SetTitle("Confirm delete");
				alert.SetMessage("Lorem ipsum dolor sit amet, consectetuer adipiscing elit.");
				alert.SetPositiveButton("Delete", (senderAlert, args) =>
				{
					Toast.MakeText(this, "Deleted!", ToastLength.Short).Show();
				});
				Dialog dialog = alert.Create();
				dialog.Show();*/
				Toast.MakeText(this, "Location Service not available!", ToastLength.Long).Show();
			}
		}

		public void OnProviderEnabled(string provider)
		{

  		}

		public void OnProviderDisabled(string provider)
		{

  		}

		public void OnStatusChanged(string provider, Availability status, Bundle extras)
		{

  		}

		public void OnLocationChanged(Android.Locations.Location location)
		{
			FindViewById<TextView>(Resource.Id.textView3).Text = "" + location.Latitude;
			FindViewById<TextView>(Resource.Id.textView5).Text = "" + location.Longitude;
			if (map != null)
			{
				LatLng myLocation = new LatLng(location.Latitude, location.Longitude);
				CameraPosition.Builder builder = CameraPosition.InvokeBuilder();
				builder.Target(myLocation);
				builder.Zoom(18);
				CameraPosition cameraPosition = builder.Build();
				CameraUpdate cameraUpdate = CameraUpdateFactory.NewCameraPosition(cameraPosition);
				map.MoveCamera(cameraUpdate);
				MarkerOptions marker = new MarkerOptions();
				marker.SetTitle("You");
				marker.SetPosition(myLocation);
				map.Clear();
				map.AddMarker(marker);
			}
		}
	}
}
