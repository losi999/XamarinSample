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
    [Register ("SettingsViewController")]
    partial class SettingsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelPicker { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelSlider { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView pickerSettings { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider sliderSettings { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch switchSettings { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (labelPicker != null) {
                labelPicker.Dispose ();
                labelPicker = null;
            }

            if (labelSlider != null) {
                labelSlider.Dispose ();
                labelSlider = null;
            }

            if (labelSwitch != null) {
                labelSwitch.Dispose ();
                labelSwitch = null;
            }

            if (pickerSettings != null) {
                pickerSettings.Dispose ();
                pickerSettings = null;
            }

            if (sliderSettings != null) {
                sliderSettings.Dispose ();
                sliderSettings = null;
            }

            if (switchSettings != null) {
                switchSettings.Dispose ();
                switchSettings = null;
            }
        }
    }
}