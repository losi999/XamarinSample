using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinSample.Core.ViewModel;
using GalaSoft.MvvmLight.Helpers;

namespace XamarinSample.Android.Activities {
    [Activity(Label = "SettingsActivity")]
    public class SettingsActivity : ActivityBase<ISettingsViewModel> {
        protected override ISettingsViewModel ViewModel => App.Locator.Settings;

        private CheckBox checkBoxSettings => FindViewById<CheckBox>(Resource.Id.checkBoxSettings);
        private Switch switchSettings => FindViewById<Switch>(Resource.Id.switchSettings);
        private SeekBar seekBarSettings => FindViewById<SeekBar>(Resource.Id.seekBarSettings);
        private Spinner spinnerSettings => FindViewById<Spinner>(Resource.Id.spinnerSettings);

        private TextView textViewCheckBox => FindViewById<TextView>(Resource.Id.textViewCheckBox);
        private TextView textViewSwitch => FindViewById<TextView>(Resource.Id.textViewSwitch);
        private TextView textViewSeekBar => FindViewById<TextView>(Resource.Id.textViewSeekBar);
        private TextView textViewSpinner => FindViewById<TextView>(Resource.Id.textViewSpinner);


        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Settings);

            bindings.Add(this.SetBinding(() => ViewModel.IsCheckBoxChecked, () => checkBoxSettings.Checked, BindingMode.TwoWay));
            bindings.Add(this.SetBinding(() => ViewModel.IsCheckBoxChecked, () => textViewCheckBox.Text).ConvertSourceToTarget((isChecked) => {
                return isChecked ? "CheckBox checked" : "CheckBox unchecked";
            }));


            bindings.Add(this.SetBinding(() => ViewModel.IsSwitchChecked, () => switchSettings.Checked, BindingMode.TwoWay));
            bindings.Add(this.SetBinding(() => ViewModel.IsSwitchChecked, () => textViewSwitch.Text).ConvertSourceToTarget((isChecked) => {
                return isChecked ? "Switch on" : "Switch off";
            }));


            bindings.Add(this.SetBinding(() => ViewModel.BarValue, () => seekBarSettings.Progress, BindingMode.TwoWay).ObserveTargetEvent<SeekBar.ProgressChangedEventArgs>("ProgressChanged"));
            bindings.Add(this.SetBinding(() => ViewModel.BarValue, () => textViewSeekBar.Text).ConvertSourceToTarget((value) => {
                return "SeekBar value: " + value;
            }));


            spinnerSettings.Adapter = ViewModel.Items.GetAdapter(GetSpinnerView);
            bindings.Add(this.SetBinding(() => ViewModel.SelectedItemIndex).WhenSourceChanges(() => {
                if (spinnerSettings.SelectedItemPosition != ViewModel.SelectedItemIndex) {
                    spinnerSettings.SetSelection(ViewModel.SelectedItemIndex);
                }
            }));
            bindings.Add(this.SetBinding(() => spinnerSettings.SelectedItemPosition, () => ViewModel.SelectedItemIndex).ObserveSourceEvent<AdapterView.ItemSelectedEventArgs>("ItemSelected"));
            bindings.Add(this.SetBinding(() => ViewModel.SelectedItem, () => textViewSpinner.Text));


        }

        private View GetSpinnerView(int position, string item, View view) {
            view = LayoutInflater.Inflate(Resource.Layout.SimpleSpinnerItem, null);

            var label = view.FindViewById<TextView>(Resource.Id.textViewSpinnerItemLabel);
            label.Text = item;
            //bindings.Add(new Binding<string, string>(item, () => item, label, () => label.Text));
            return view;
        }
    }
}