using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSample.Core.ViewModel {
    public interface ISignUpViewModel : IViewModelBase {
        string Username { get; set; }
        string Password { get; set; }
        string PasswordConfirm { get; set; }
        RelayCommand CommandSignUp { get; }
        bool IsInProgress { get; set; }
    }
}
