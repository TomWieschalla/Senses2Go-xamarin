// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace senses2go
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		senses2go.MainViewController MainViewController { get; set; }

		[Action ("gpsButton:")]
		partial void gpsButton (Foundation.NSObject sender);

		[Action ("gpsButtonClicked:")]
		partial void gpsButtonClicked (UIKit.UIButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (MainViewController != null) {
				MainViewController.Dispose ();
				MainViewController = null;
			}
		}
	}
}
