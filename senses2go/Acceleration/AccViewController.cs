using System;

using UIKit;
using CoreMotion;
using Foundation;

namespace senses2go
{
	public partial class AccViewController : UIViewController
	{
		CMMotionManager motionManager;

		public AccViewController() : base("AccViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			base.Title = "Beschleunigung";

			motionManager = new CMMotionManager();
			motionManager.StartAccelerometerUpdates(NSOperationQueue.CurrentQueue, (data, error) =>
		   {
				this.label1.Text = "" + data.Acceleration.X;
				this.label2.Text = "" + data.Acceleration.Y;
				this.label3.Text = "" + data.Acceleration.Z;
		   });
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

