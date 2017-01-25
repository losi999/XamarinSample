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
    [Register ("PersonDetailsViewController")]
    partial class PersonDetailsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonDeletePerson { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonDial { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonSendEMail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonShowOnMap { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imageViewPhotoPreview { get; set; }

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
            if (buttonDeletePerson != null) {
                buttonDeletePerson.Dispose ();
                buttonDeletePerson = null;
            }

            if (buttonDial != null) {
                buttonDial.Dispose ();
                buttonDial = null;
            }

            if (buttonSendEMail != null) {
                buttonSendEMail.Dispose ();
                buttonSendEMail = null;
            }

            if (buttonShowOnMap != null) {
                buttonShowOnMap.Dispose ();
                buttonShowOnMap = null;
            }

            if (imageViewPhotoPreview != null) {
                imageViewPhotoPreview.Dispose ();
                imageViewPhotoPreview = null;
            }

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