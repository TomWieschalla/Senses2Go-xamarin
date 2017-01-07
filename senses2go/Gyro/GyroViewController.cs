using System;

using UIKit;
using CoreMotion;
using Foundation;

namespace senses2go
{
	public partial class GyroViewController : UIViewController
	{
		CMMotionManager motionManager;

		public GyroViewController() : base("GyroViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			base.Title = "Rotation";

			motionManager = new CMMotionManager();
			motionManager.StartGyroUpdates(NSOperationQueue.CurrentQueue, (data, error) =>
		   {
				this.label1.Text = "" + data.RotationRate.x;
			   this.label2.Text = "" + data.RotationRate.y;
			   this.label3.Text = "" + data.RotationRate.z;
		   });
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

