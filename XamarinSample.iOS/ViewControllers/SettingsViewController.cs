using GalaSoft.MvvmLight.Helpers;
using System;

using UIKit;
using XamarinSample.Core.ViewModel;
using XamarinSample.iOS.ViewControllers;
using Foundation;
using System.Collections.ObjectModel;
using XamarinSample.iOS.Extensions;

namespace XamarinSample.iOS.ViewControllers {
    public partial class SettingsViewController : ViewControllerBase<ISettingsViewModel> {
        protected override ISettingsViewModel ViewModel => Application.Locator.Settings;

        public SettingsViewController(IntPtr handle) : base(handle) {
        }

        public override void DidReceiveMemoryWarning() {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad() {
            base.ViewDidLoad();

            bindings.Add(this.SetBinding(() => ViewModel.IsSwitchChecked, () => switchSettings.On, BindingMode.TwoWay));
            bindings.Add(this.SetBinding(() => ViewModel.IsSwitchChecked, () => labelSwitch.Text).ConvertSourceToTarget((isChecked) => {
                return isChecked ? "Switch on" : "Switch off";
            }));

            bindings.Add(this.SetBinding(() => ViewModel.BarValue, () => sliderSettings.Value, BindingMode.TwoWay).ObserveTargetEvent("ValueChanged"));
            bindings.Add(this.SetBinding(() => ViewModel.BarValue, () => labelSlider.Text).ConvertSourceToTarget((value) => {
                return "Slider value: " + value;
            }));

            pickerSettings.Model = ViewModel.Items.GetModel(PickerItemSelected);
            pickerSettings.Select(ViewModel.SelectedItemIndex, 0, false);
            bindings.Add(this.SetBinding(() => ViewModel.SelectedItem, () => labelPicker.Text));
        }

        private void PickerItemSelected(int index) {
            ViewModel.SelectedItemIndex = index;
        }
    }
}