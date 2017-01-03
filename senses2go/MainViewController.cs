using Foundation;
using System;
using UIKit;

namespace senses2go
{
    public partial class MainViewController : UIView
    {
        public MainViewController (IntPtr handle) : base (handle)
        {
        }

		void HandleTouchUpInside(object sender, EventArgs ea)
		{
			new UIAlertView("Touch3", "TouchUpInside handled", null, "OK", null).Show();
		}
			
    }
}