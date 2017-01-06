using System;

using UIKit;

namespace senses2go
{
	public partial class SoundViewController : UIViewController
	{
		public SoundViewController() : base("SoundViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			base.Title = "Lautsprecher";
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

