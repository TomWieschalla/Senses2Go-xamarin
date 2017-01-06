using System;

using UIKit;

namespace senses2go
{
	public partial class MagnoViewController : UIViewController
	{
		public MagnoViewController() : base("MagnoViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			base.Title = "Erdfeldstärke";
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

