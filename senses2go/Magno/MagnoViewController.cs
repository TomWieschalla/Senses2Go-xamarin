using System;

using UIKit;
using CoreMotion;
using Foundation;

namespace senses2go
{
	public partial class MagnoViewController : UIViewController
	{
		CMMotionManager motionManager;

		public MagnoViewController() : base("MagnoViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			base.Title = "Erdfeldstärke";
			motionManager = new CMMotionManager();
			motionManager.StartMagnetometerUpdates(NSOperationQueue.CurrentQueue, (data, error) =>
		   {
				this.label1.Text = "" + data.MagneticField.X;
				this.label2.Text = "" + data.MagneticField.Y;
				this.label3.Text = "" + data.MagneticField.Z;
		   });		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

