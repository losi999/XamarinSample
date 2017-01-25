using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using XamarinSample.Core.ViewModel;
using XamarinSample.Core.Services;
using GS = GalaSoft.MvvmLight.Views;

namespace XamarinSample.ViewModel {
    public class LogInViewModel : ViewModelBase, ILogInViewModel {
        private INavigationService _navigation;
        private IWebService _web;
        private GS.IDialogService _dialog;

        public LogInViewModel(INavigationService navigation, IWebService web, GS.IDialogService dialog) {
            _navigation = navigation;
            _web = web;
            _dialog = dialog;
        }

        private RelayCommand _CommandBackPressed;
        public RelayCommand CommandBackPressed => _CommandBackPressed ??
            (_CommandBackPressed = new RelayCommand(() => {

            }));

        private RelayCommand _CommandLogIn;
        public RelayCommand CommandLogIn => _CommandLogIn ??
            (_CommandLogIn = new RelayCommand(async () => {
                if (String.IsNullOrEmpty(Username)) {
                    await _dialog.ShowMessage("Missing username!", "Error");
                    return;
                }
                if (String.IsNullOrEmpty(Password)) {
                    await _dialog.ShowMessage("Missing password!", "Error");
                    return;
                }

                IsInProgress = true;
                var response = await _web.LogIn(Username, Password);
                if (String.IsNullOrEmpty(response)) {
                    //TODO navigate forward
                }
                else {
                    await _dialog.ShowMessage(response, "Error");
                    IsInProgress = false;
                }
            }));

        private RelayCommand _CommandSignUp;
        public RelayCommand CommandSignUp => _CommandSignUp ??
            (_CommandSignUp = new RelayCommand(() => {
                _navigation.NavigateToSignUpPage();
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
