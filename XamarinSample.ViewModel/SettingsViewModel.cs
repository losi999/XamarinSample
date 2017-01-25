using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.ViewModel;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using XamarinSample.Core.Services;

namespace XamarinSample.ViewModel {
    public class SettingsViewModel : ViewModelBase, ISettingsViewModel {
        private IApplicationSettingsService _settings;
        private INavigationService _navigation;

        public SettingsViewModel(IApplicationSettingsService settings, INavigationService navigation) {
            _navigation = navigation;
            _settings = settings;

            Items = new ObservableCollection<string>();
            for (int i = 1; i <= 10; i++) {
                Items.Add("Spinner item " + i);
            }
        }

        private RelayCommand _CommandBackPressed;
        public RelayCommand CommandBackPressed => _CommandBackPressed ??
            (_CommandBackPressed = new RelayCommand(() => {
                _navigation.GoBack();
            }));

        public bool IsCheckBoxChecked {
            get {
                return _settings.IsCheckBoxChecked;
            }
            set {
                if (_settings.IsCheckBoxChecked != value) {
                    _settings.IsCheckBoxChecked = value;
                    RaisePropertyChanged(nameof(IsCheckBoxChecked));
                }
            }
        }

        public bool IsSwitchChecked {
            get {
                return _settings.IsSwitchChecked;
            }
            set {
                if (_settings.IsSwitchChecked != value) {
                    _settings.IsSwitchChecked = value;
                    RaisePropertyChanged(nameof(IsSwitchChecked));
                }
            }
        }

        public int BarValue {
            get {
                return _settings.BarValue;
            }
            set {
                if (_settings.BarValue != value) {
                    _settings.BarValue = value;
                    RaisePropertyChanged(nameof(BarValue));
                }
            }
        }

        public ObservableCollection<string> Items { get; }

        public int _SelectedItemIndex;
        public int SelectedItemIndex {
            get {
                _SelectedItemIndex = Math.Max(Items.IndexOf(_settings.SelectedItem), 0);
                return _SelectedItemIndex;
            }
            set {
                if (_SelectedItemIndex != value) {
                    _SelectedItemIndex = value;
                    _settings.SelectedItem = Items[_SelectedItemIndex];
                    RaisePropertyChanged(nameof(SelectedItemIndex));
                    RaisePropertyChanged(nameof(SelectedItem));
                }
            }
        }

        public string SelectedItem => Items[SelectedItemIndex];
    }
}
