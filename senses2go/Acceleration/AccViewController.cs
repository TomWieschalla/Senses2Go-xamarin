using System;

using UIKit;

namespace senses2go
{
	public partial class AccViewController : UIViewController
	{
		public AccViewController() : base("AccViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			base.Title = "Beschleunigung";
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

