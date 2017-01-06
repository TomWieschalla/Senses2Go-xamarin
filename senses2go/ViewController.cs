using System;

using UIKit;

namespace senses2go
{
	public partial class ViewController : UIViewController
	{

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void gpsButtonClicked (UIButton sender)
		{
			NavigationController.PushViewController(new GPSViewController(), true);
		}

		partial void gyroButtonClicked(UIButton sender)
		{
			NavigationController.PushViewController(new GyroViewController(), true);
		}

		partial void magnetometerButtonClicked(UIButton sender)
		{
			NavigationController.PushViewController(new MagnoViewController(), true);
		}

		partial void accButtonClicked(UIButton sender)
		{
			NavigationController.PushViewController(new AccViewController(), true);
		}

		partial void proxButtonClicked(UIButton sender)
		{
			NavigationController.PushViewController(new ProxViewController(), true);
		}

		partial void pressureButtonClicked(UIButton sender)
		{
			NavigationController.PushViewController(new PressureViewController(), true);
		}

		partial void lightButtonClicked(UIButton sender)
		{
			NavigationController.PushViewController(new LightViewController(), true);
		}

		partial void cameraButtonClicked(UIButton sender)
		{
			NavigationController.PushViewController(new CameraViewController(), true);
		}

		partial void soundButtonClicked(UIButton sender)
		{
			NavigationController.PushViewController(new SoundViewController(), true);
		}

		partial void microButtonClicked(UIButton sender)
		{
			NavigationController.PushViewController(new MicroViewController(), true);
		}
	}
}

