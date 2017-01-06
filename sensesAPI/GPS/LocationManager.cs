using System;
using UIKit;
using CoreLocation;

namespace sensesAPI
{
	public class LocationManager
	{
		protected CLLocationManager locMgr;

		// event for the location changing
		public event EventHandler<LocationUpdatedEventArgs> LocationUpdated = delegate { };

		public LocationManager()
		{
			this.locMgr = new CLLocationManager();
			this.locMgr.PausesLocationUpdatesAutomatically = false;

			// iOS 8 has additional permissions requirements
			if (UIDevice.CurrentDevice.CheckSystemVersion(8, 0))
			{
				locMgr.RequestAlwaysAuthorization(); 												 
			}

			if (UIDevice.CurrentDevice.CheckSystemVersion(9, 0))
			{
				locMgr.AllowsBackgroundLocationUpdates = true;
			}
		}

		public CLLocationManager LocMgr
		{
			get { return this.locMgr; }
		}

		public void StartLocationUpdates()
		{
			if (CLLocationManager.LocationServicesEnabled)
			{
				//set the desired accuracy, in meters
				LocMgr.DesiredAccuracy = 1;
				LocMgr.LocationsUpdated += (object sender, CLLocationsUpdatedEventArgs e) =>
				{
	  				LocationUpdated(this, new LocationUpdatedEventArgs(e.Locations[e.Locations.Length - 1]));
				};
				LocMgr.StartUpdatingLocation();
			}
		}
	}
}
