using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSample.Core.ViewModel {
    public interface ILogInViewModel : IViewModelBase {
        string Username { get; set; }
        string Password { get; set; }
        bool IsInProgress { get; set; }
        RelayCommand CommandLogIn { get; }
        RelayCommand CommandSignUp { get; }
    }
}
