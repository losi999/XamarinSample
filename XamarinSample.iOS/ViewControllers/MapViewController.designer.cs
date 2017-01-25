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
    [Register ("MapViewController")]
    partial class MapViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonCurrentLocation { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonDirections { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonMapsApplication { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton buttonPointsInArea { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (buttonCurrentLocation != null) {
                buttonCurrentLocation.Dispose ();
                buttonCurrentLocation = null;
            }

            if (buttonDirections != null) {
                buttonDirections.Dispose ();
                buttonDirections = null;
            }

            if (buttonMapsApplication != null) {
                buttonMapsApplication.Dispose ();
                buttonMapsApplication = null;
            }

            if (buttonPointsInArea != null) {
                buttonPointsInArea.Dispose ();
                buttonPointsInArea = null;
            }
        }
    }
}