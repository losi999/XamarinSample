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
        UIKit.UIButton buttonClick { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonSecondPage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelCount { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (buttonClick != null) {
                buttonClick.Dispose ();
                buttonClick = null;
            }

            if (buttonSecondPage != null) {
                buttonSecondPage.Dispose ();
                buttonSecondPage = null;
            }

            if (labelCount != null) {
                labelCount.Dispose ();
                labelCount = null;
            }
        }
    }
}