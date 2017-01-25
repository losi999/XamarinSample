using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.ViewModel;
using GalaSoft.MvvmLight.Command;
using XamarinSample.Core.Services;
using GS = GalaSoft.MvvmLight.Views;

namespace XamarinSample.ViewModel {
    public class SignUpViewModel : ViewModelBase, ISignUpViewModel {
        private INavigationService _navigation;
        private GS.IDialogService _dialog;
        private IWebService _web;

        public SignUpViewModel(INavigationService navigation, IWebService web, GS.IDialogService dialog) {
            _navigation = navigation;
            _web = web;
            _dialog = dialog;
        }

        private RelayCommand _CommandBackPressed;
        public RelayCommand CommandBackPressed => _CommandBackPressed ??
            (_CommandBackPressed = new RelayCommand(() => {

            }));

        private RelayCommand _CommandSignUp;
        public RelayCommand CommandSignUp => _CommandSignUp ??
            (_CommandSignUp = new RelayCommand(async () => {
                if (String.IsNullOrEmpty(Username)) {
                    await _dialog.ShowMessage("Missing username!", "Error");
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
                IsInProgress = true;
                if (await _web.SignUp(Username, Password)) {
                    _navigation.GoBack();
                }
                else {
                    await _dialog.ShowMessage("error", "Error");
                }
                IsInProgress = false;
            }));

        private string _Username;
        public string Username {
            get {
                return _Username;
            }
            set {
                if (_Username != value) {
                    _Username = value;
                    RaisePropertyChanged(nameof(Username));
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


        private bool _IsInProgress;
        public bool IsInProgress {
            get {
                return _IsInProgress;
            }
            set {
                if (_IsInProgress != value) {
                    _IsInProgress = value;
                    RaisePropertyChanged(nameof(IsInProgress));
                }
            }
        }
    }
}
