using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Model.Enum;
using XamarinSample.Core.Model.ItemModels;

namespace XamarinSample.Core.ViewModel {
    public interface IPersonDetailsViewModel : IViewModelBase {
        string Name { get; }
        int Age { get; }
        Gender Gender { get; }
        string Address { get; }
        string EMail { get; }
        string PhoneNumber { get; }
        string PhotoPath { get; }

        RelayCommand CommandDeletePerson { get; }

        RelayCommand CommandDial { get; }
        RelayCommand CommandSendEMail { get; }
        RelayCommand CommandShowOnMap { get; }


        string PersonId { get; set; }
    }
}
