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
    [Register ("PersonOptionalViewController")]
    partial class PersonOptionalViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonNext { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonTakePhoto { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imageViewPhotoPreview { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textFieldAddress { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textFieldEMail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textFieldPhoneNumber { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (buttonNext != null) {
                buttonNext.Dispose ();
                buttonNext = null;
            }

            if (buttonTakePhoto != null) {
                buttonTakePhoto.Dispose ();
                buttonTakePhoto = null;
            }

            if (imageViewPhotoPreview != null) {
                imageViewPhotoPreview.Dispose ();
                imageViewPhotoPreview = null;
            }

            if (textFieldAddress != null) {
                textFieldAddress.Dispose ();
                textFieldAddress = null;
            }

            if (textFieldEMail != null) {
                textFieldEMail.Dispose ();
                textFieldEMail = null;
            }

            if (textFieldPhoneNumber != null) {
                textFieldPhoneNumber.Dispose ();
                textFieldPhoneNumber = null;
            }
        }
    }
}