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
    [Register ("MicroViewController")]
    partial class MicroViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton playButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton recButton { get; set; }

        [Action ("play:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void play (UIKit.UIButton sender);

        [Action ("record:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void record (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (playButton != null) {
                playButton.Dispose ();
                playButton = null;
            }

            if (recButton != null) {
                recButton.Dispose ();
                recButton = null;
            }
        }
    }
}