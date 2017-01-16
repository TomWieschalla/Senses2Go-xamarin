using System;

using UIKit;
using Foundation;

namespace senses2go
{
	public partial class ProxViewController : UIViewController
	{
		public ProxViewController() : base("ProxViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			base.Title = "Entfernung";
			var device = UIDevice.CurrentDevice;
			device.ProximityMonitoringEnabled = true;
			if (device.ProximityMonitoringEnabled)
			{
				NSNotificationCenter.DefaultCenter.AddObserver(UIDevice.ProximityStateDidChangeNotification, (NSNotification obj) =>
				 {
					device = (UIDevice) obj.Object;
					 if (device.ProximityState)
					 {
						base.View.BackgroundColor = UIColor.Red;
					 }
					 else 
					 {
						 base.View.BackgroundColor = UIColor.White;
					 }
						
				}, device);
			}
		}

		public override void ViewWillDisappear(bool animated)
		{
			base.ViewWillDisappear(animated);
			var device = UIDevice.CurrentDevice;
			device.ProximityMonitoringEnabled = false;
		}
	}
}

