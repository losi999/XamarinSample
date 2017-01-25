using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.DesignViewModel {
    public class SignUpViewModel : ISignUpViewModel {
        public SignUpViewModel() {
            Username = "user";
            Password = "pass";
            PasswordConfirm = "pass";

            IsInProgress = true;
        }

        public RelayCommand CommandBackPressed { get; }
        public RelayCommand CommandSignUp { get; }

        public bool IsInProgress { get; set; }

        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string Username { get; set; }
    }
}
