using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using XamarinSample.Core.Model.ItemModels;
using XamarinSample.Core.Model.Enum;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.DesignViewModel {
    public class PersonDetailsViewModel : IPersonDetailsViewModel {
        public PersonDetailsViewModel() {
            Name = "name";
            Gender = Gender.Male;
            Age = 23;
            Address = "some address";
            EMail = "some e-mail";
            PhoneNumber = "some phone";
        }

        public RelayCommand CommandBackPressed { get; }
        public RelayCommand CommandDial { get; }
        public RelayCommand CommandSendEMail { get; }
        public RelayCommand CommandShowOnMap { get; }
        public RelayCommand CommandDeletePerson { get; }

        public string Address { get; }
        public int Age { get; }
        public Gender Gender { get; }
        public string EMail { get; }
        public string Name { get; }
        public string PhoneNumber { get; }
        public string PhotoPath { get; }

        public string PersonId { get; set; }
    }
}
