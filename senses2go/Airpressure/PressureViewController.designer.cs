// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace senses2go
{
    [Register ("PressureViewController")]
    partial class PressureViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel label1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel label2 { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (label1 != null) {
                label1.Dispose ();
                label1 = null;
            }

            if (label2 != null) {
                label2.Dispose ();
                label2 = null;
            }
        }
    }
}