using System;

using UIKit;
using CoreMotion;
using Foundation;

namespace senses2go
{
	public partial class PressureViewController : UIViewController
	{
		public PressureViewController() : base("PressureViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			base.Title = "Luftdruck";
			if (CMAltimeter.IsRelativeAltitudeAvailable)
			{
				var altimeter = new CMAltimeter();
				altimeter.StartRelativeAltitudeUpdates(NSOperationQueue.CurrentQueue, (arg1, arg2) =>
				{
					this.label1.Text = "" + arg1.Pressure;
				});
			}
			else {
				this.imageView.Hidden = false;
				this.label0.Hidden = true;
				this.label1.Hidden = true;
			}
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

