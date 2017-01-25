using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSample.Core.ViewModel {
    public interface IPersonSummaryViewModel : IViewModelBase {
        string SummaryText { get; }
        string PhotoPath { get; }
        string Password { get; set; }
        RelayCommand CommandSave { get; }
    }
}
