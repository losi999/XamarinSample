using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using XamarinSample.Core.Model.Enum;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.DesignViewModel {
    public class PersonRequiredViewModel : IPersonRequiredViewModel {
        public PersonRequiredViewModel() {
            Age = 23;
            FirstName = "design time first name";
            LastName = "design time last name";
            Password = "design time password";
            PasswordConfirm = "design time password";
            Gender = Gender.Male;
        }

        public string Id { get; set; }
        public int Age { get; set; }
        public RelayCommand CommandBackPressed { get; }
        public RelayCommand CommandNext { get; }
        public string FirstName { get; set; }
        public Gender Gender { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }

        public void ClearProperties() { }
    }
}
