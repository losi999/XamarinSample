using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.DesignViewModel {
    public class PersonOptionalViewModel : IPersonOptionalViewModel {
        public PersonOptionalViewModel() {
            Address = "design time address";
            EMail = "design time email";
            PhoneNumber = "+361234567";
        }

        public string Address { get; set; }
        public RelayCommand CommandBackPressed { get; }
        public RelayCommand CommandNext { get; }
        public RelayCommand CommandTakePhoto { get; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public string PhotoPath { get; set; }

        public void ClearProperties() { }
    }
}
