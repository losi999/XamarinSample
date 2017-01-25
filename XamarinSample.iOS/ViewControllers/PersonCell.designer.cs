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
    [Register ("PersonCell")]
    partial class PersonCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelAddress { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelAge { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelEMail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelGender { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelPhoneNumber { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (labelAddress != null) {
                labelAddress.Dispose ();
                labelAddress = null;
            }

            if (labelAge != null) {
                labelAge.Dispose ();
                labelAge = null;
            }

            if (labelEMail != null) {
                labelEMail.Dispose ();
                labelEMail = null;
            }

            if (labelGender != null) {
                labelGender.Dispose ();
                labelGender = null;
            }

            if (labelName != null) {
                labelName.Dispose ();
                labelName = null;
            }

            if (labelPhoneNumber != null) {
                labelPhoneNumber.Dispose ();
                labelPhoneNumber = null;
            }
        }
    }
}