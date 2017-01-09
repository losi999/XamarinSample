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
    [Register ("SecondViewController")]
    partial class SecondViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonDialog { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonDownloadJson { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelDialogResponse { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView tableViewRestaurants { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (buttonDialog != null) {
                buttonDialog.Dispose ();
                buttonDialog = null;
            }

            if (buttonDownloadJson != null) {
                buttonDownloadJson.Dispose ();
                buttonDownloadJson = null;
            }

            if (labelDialogResponse != null) {
                labelDialogResponse.Dispose ();
                labelDialogResponse = null;
            }

            if (tableViewRestaurants != null) {
                tableViewRestaurants.Dispose ();
                tableViewRestaurants = null;
            }
        }
    }
}