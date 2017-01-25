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

namespace XamarinSample.iOS.ViewControllers 
{
    [Register ("DialogsViewController")]
    partial class DialogsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonDialogCustomButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonDialogCustomButtonError { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonDialogCustomButtonException { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonDialogCustomTwoButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonDialogOkButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelTwoButtonResponse { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (buttonDialogCustomButton != null) {
                buttonDialogCustomButton.Dispose ();
                buttonDialogCustomButton = null;
            }

            if (buttonDialogCustomButtonError != null) {
                buttonDialogCustomButtonError.Dispose ();
                buttonDialogCustomButtonError = null;
            }

            if (buttonDialogCustomButtonException != null) {
                buttonDialogCustomButtonException.Dispose ();
                buttonDialogCustomButtonException = null;
            }

            if (buttonDialogCustomTwoButton != null) {
                buttonDialogCustomTwoButton.Dispose ();
                buttonDialogCustomTwoButton = null;
            }

            if (buttonDialogOkButton != null) {
                buttonDialogOkButton.Dispose ();
                buttonDialogOkButton = null;
            }

            if (labelTwoButtonResponse != null) {
                labelTwoButtonResponse.Dispose ();
                labelTwoButtonResponse = null;
            }
        }
    }
}