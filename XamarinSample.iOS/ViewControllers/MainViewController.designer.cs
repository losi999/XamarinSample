// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamarinSample.iOS.ViewControllers
{
    [Register ("MainViewController")]
    partial class MainViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonDialogs { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonMap { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonPersons { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonSettings { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (buttonDialogs != null) {
                buttonDialogs.Dispose ();
                buttonDialogs = null;
            }

            if (buttonMap != null) {
                buttonMap.Dispose ();
                buttonMap = null;
            }

            if (buttonPersons != null) {
                buttonPersons.Dispose ();
                buttonPersons = null;
            }

            if (buttonSettings != null) {
                buttonSettings.Dispose ();
                buttonSettings = null;
            }
        }
    }
}