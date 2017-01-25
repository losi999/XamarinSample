using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSample.Core.ViewModel {
    public interface IDialogsViewModel : IViewModelBase {
        RelayCommand CommandDialogOkButton { get; }
        RelayCommand CommandDialogCustomButton { get; }
        RelayCommand CommandDialogCustomTwoButton { get; }
        RelayCommand CommandDialogCustomButtonException { get; }
        RelayCommand CommandDialogCustomButtonError { get; }
        string TwoButtonResponse { get; set; }
    }
}
