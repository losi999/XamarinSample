using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Model.Enum;

namespace XamarinSample.Core.ViewModel {
    public interface IPersonRequiredViewModel : IViewModelBase {
        RelayCommand CommandNext { get; }

        string Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        Gender Gender { get; set; }
        int Age { get; set; }
        string Password { get; set; }
        string PasswordConfirm { get; set; }

        void ClearProperties();
    }
}
