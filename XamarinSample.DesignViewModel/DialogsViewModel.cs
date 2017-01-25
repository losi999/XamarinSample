using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.DesignViewModel {
    public class DialogsViewModel : IDialogsViewModel {
        public DialogsViewModel() {
            TwoButtonResponse = "design time response";
        }

        public RelayCommand CommandBackPressed { get; }
        public RelayCommand CommandDialogCustomButton { get; }
        public RelayCommand CommandDialogCustomButtonError { get; }
        public RelayCommand CommandDialogCustomButtonException { get; }
        public RelayCommand CommandDialogCustomTwoButton { get; }
        public RelayCommand CommandDialogOkButton { get; }

        public string TwoButtonResponse { get; set; }
    }
}
