using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.ViewModel;
using GalaSoft.MvvmLight.Command;
using XamarinSample.Core.Model.Enum;
using XamarinSample.Core.Services;
using GS = GalaSoft.MvvmLight.Views;

namespace XamarinSample.ViewModel {
    public class PersonRequiredViewModel : ViewModelBase, IPersonRequiredViewModel {
        private INavigationService _navigation;
        private GS.IDialogService _dialog;

        public PersonRequiredViewModel(INavigationService navigation, GS.IDialogService dialog) {
            _navigation = navigation;
            _dialog = dialog;

            Id = Guid.NewGuid().ToString();
        }

        private RelayCommand _CommandNext;
        public RelayCommand CommandNext => _CommandNext ??
            (_CommandNext = new RelayCommand(async () => {
                if (String.IsNullOrEmpty(FirstName)) {
                    await _dialog.ShowMessage("Missing first name!", "Error");
                    return;
                }
                if (String.IsNullOrEmpty(LastName)) {
                    await _dialog.ShowMessage("Missing last name!", "Error");
                    return;
                }
                if (Age <= 0) {
                    await _dialog.ShowMessage("Invalid age!", "Error");
                    return;
                }
                if (String.IsNullOrEmpty(Password)) {
                    await _dialog.ShowMessage("Missing password!", "Error");
                    return;
                }

                if (String.IsNullOrEmpty(PasswordConfirm)) {
                    await _dialog.ShowMessage("Missing password!", "Error");
                    return;
                }
                if (Password != PasswordConfirm) {
                    await _dialog.ShowMessage("Passwords don't match!", "Error");
                    return;
                }
                _navigation.NavigateToPersonOptionalPage();
            }));

        private RelayCommand _CommandBackPressed;
        public RelayCommand CommandBackPressed => _CommandBackPressed ??
            (_CommandBackPressed = new RelayCommand(() => {
                _navigation.GoBack();
            }));

        public string Id { get; set; }

        private int _Age;
        public int Age {
            get {
                return _Age;
            }
            set {
                if (_Age != value) {
                    _Age = value;
                    RaisePropertyChanged(nameof(Age));
                }
            }
        }

        private string _FirstName;
        public string FirstName {
            get {
                return _FirstName;
            }
            set {
                if (_FirstName != value) {
                    _FirstName = value;
                    RaisePropertyChanged(nameof(FirstName));
                }
            }
        }


        private Gender _Gender;
        public Gender Gender {
            get {
                return _Gender;
            }
            set {
                if (Gender.Undefined != value) {
                    _Gender = value;
                    RaisePropertyChanged(nameof(Gender));
                }
            }
        }

        private string _LastName;
        public string LastName {
            get {
                return _LastName;
            }
            set {
                if (_LastName != value) {
                    _LastName = value;
                    RaisePropertyChanged(nameof(LastName));
                }
            }
        }

        private string _Password;
        public string Password {
            get {
                return _Password;
            }
            set {
                if (_Password != value) {
                    _Password = value;
                    RaisePropertyChanged(nameof(Password));
                }
            }
        }

        private string _PasswordConfirm;
        public string PasswordConfirm {
            get {
                return _PasswordConfirm;
            }
            set {
                if (_PasswordConfirm != value) {
                    _PasswordConfirm = value;
                    RaisePropertyChanged(nameof(PasswordConfirm));
                }
            }
        }

        public void ClearProperties() {
            Id = Guid.NewGuid().ToString();
            Password = "";
            PasswordConfirm = "";
            LastName = "";
            FirstName = "";
            Age = 0;
            Gender = Gender.Male;
        }
    }
}
