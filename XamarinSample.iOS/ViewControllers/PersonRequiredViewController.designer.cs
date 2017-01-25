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
    [Register ("PersonRequiredViewController")]
    partial class PersonRequiredViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonNext { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textFieldAge { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textFieldFirstName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textFieldLastName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textFieldPassword { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textFieldPasswordConfirm { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (buttonNext != null) {
                buttonNext.Dispose ();
                buttonNext = null;
            }

            if (textFieldAge != null) {
                textFieldAge.Dispose ();
                textFieldAge = null;
            }

            if (textFieldFirstName != null) {
                textFieldFirstName.Dispose ();
                textFieldFirstName = null;
            }

            if (textFieldLastName != null) {
                textFieldLastName.Dispose ();
                textFieldLastName = null;
            }

            if (textFieldPassword != null) {
                textFieldPassword.Dispose ();
                textFieldPassword = null;
            }

            if (textFieldPasswordConfirm != null) {
                textFieldPasswordConfirm.Dispose ();
                textFieldPasswordConfirm = null;
            }
        }
    }
}