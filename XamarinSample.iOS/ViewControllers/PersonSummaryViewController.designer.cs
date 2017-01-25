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
    [Register ("PersonSummaryViewController")]
    partial class PersonSummaryViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonSave { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelSummary { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textFieldPassword { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (buttonSave != null) {
                buttonSave.Dispose ();
                buttonSave = null;
            }

            if (labelSummary != null) {
                labelSummary.Dispose ();
                labelSummary = null;
            }

            if (textFieldPassword != null) {
                textFieldPassword.Dispose ();
                textFieldPassword = null;
            }
        }
    }
}