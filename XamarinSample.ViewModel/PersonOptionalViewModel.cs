using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Services;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.ViewModel {
    public class PersonOptionalViewModel : ViewModelBase, IPersonOptionalViewModel {
        private INavigationService _navigation;
        private ILauncherService _launcher;
        private IPersonRequiredViewModel _required;

        public PersonOptionalViewModel(INavigationService navigation, ILauncherService launcher, IPersonRequiredViewModel required) {
            _navigation = navigation;
            _launcher = launcher;
            _required = required;
        }

        private RelayCommand _CommandNext;
        public RelayCommand CommandNext => _CommandNext ??
            (_CommandNext = new RelayCommand(() => {
                _navigation.NavigateToPersonSummaryPage();
            }));

        private RelayCommand _CommandBackPressed;
        public RelayCommand CommandBackPressed => _CommandBackPressed ??
            (_CommandBackPressed = new RelayCommand(() => {
                _navigation.GoBack();
            }));

        private RelayCommand _CommandTakePhoto;
        public RelayCommand CommandTakePhoto => _CommandTakePhoto ??
            (_CommandTakePhoto = new RelayCommand(async () => {
                PhotoPath = await _launcher.LaunchCamera(_required.Id);
            }));

        private string _Address;
        public string Address {
            get {
                return _Address;
            }
            set {
                if (_Address != value) {
                    _Address = value;
                    RaisePropertyChanged(nameof(Address));
                }
            }
        }

        private string _EMail;
        public string EMail {
            get {
                return _EMail;
            }
            set {
                if (_EMail != value) {
                    _EMail = value;
                    RaisePropertyChanged(nameof(EMail));
                }
            }
        }


        private string _PhoneNumber;
        public string PhoneNumber {
            get {
                return _PhoneNumber;
            }
            set {
                if (_PhoneNumber != value) {
                    _PhoneNumber = value;
                    RaisePropertyChanged(nameof(PhoneNumber));
                }
            }
        }


        private string _PhotoPath;
        public string PhotoPath {
            get {
                return _PhotoPath;
            }
            set {
                if (_PhotoPath != value) {
                    _PhotoPath = value;
                    RaisePropertyChanged(nameof(PhotoPath));
                }
            }
        }

        public void ClearProperties() {
            Address = "";
            EMail = "";
            PhoneNumber = "";
        }
    }
}
