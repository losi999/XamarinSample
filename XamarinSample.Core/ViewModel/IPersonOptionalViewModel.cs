using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSample.Core.ViewModel {
    public interface IPersonOptionalViewModel : IViewModelBase {
        string Address { get; set; }
        RelayCommand CommandNext { get; }
        string EMail { get; set; }
        string PhoneNumber { get; set; }
        string PhotoPath { get; set; }

        void ClearProperties();

        RelayCommand CommandTakePhoto { get; }
    }
}
