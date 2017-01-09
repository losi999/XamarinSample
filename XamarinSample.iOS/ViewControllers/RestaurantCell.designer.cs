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
    [Register ("RestaurantCell")]
    partial class RestaurantCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelId { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (labelId != null) {
                labelId.Dispose ();
                labelId = null;
            }
        }
    }
}