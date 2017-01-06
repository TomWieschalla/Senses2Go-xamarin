using System;

using UIKit;

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
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

