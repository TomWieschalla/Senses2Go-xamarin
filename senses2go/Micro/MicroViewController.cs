using System;

using UIKit;

namespace senses2go
{
	public partial class MicroViewController : UIViewController
	{
		public MicroViewController() : base("MicroViewController", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			base.Title = "Mikrofon"; 
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

