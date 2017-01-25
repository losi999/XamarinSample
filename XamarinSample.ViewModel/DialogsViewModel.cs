using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.ViewModel;
using GalaSoft.MvvmLight.Command;
using GS = GalaSoft.MvvmLight.Views;
using XamarinSample.Core.Services;

namespace XamarinSample.ViewModel {
    public class DialogsViewModel : ViewModelBase, IDialogsViewModel {
        private GS.IDialogService _dialog;
        private INavigationService _navigation;

        public DialogsViewModel(GS.IDialogService dialog, INavigationService navigation) {
            _navigation = navigation;
            _dialog = dialog;

            TwoButtonResponse = "";
        }

        private RelayCommand _CommandDialogOkButton;
        public RelayCommand CommandDialogOkButton => _CommandDialogOkButton ??
            (_CommandDialogOkButton = new RelayCommand(() => {
                _dialog.ShowMessage("message", "title");
            }));

        private RelayCommand _CommandDialogCustomButton;
        public RelayCommand CommandDialogCustomButton => _CommandDialogCustomButton ??
            (_CommandDialogCustomButton = new RelayCommand(() => {
                _dialog.ShowMessage("message", "title", "buttonText", () => {

                });
            }));

        private RelayCommand _CommandDialogCustomTwoButton;
        public RelayCommand CommandDialogCustomTwoButton => _CommandDialogCustomTwoButton ??
            (_CommandDialogCustomTwoButton = new RelayCommand(() => {
                _dialog.ShowMessage("message", "title", "confirm", "cancel", (isConfirm) => {
                    TwoButtonResponse = isConfirm ? "Clicked confirm" : "Clicked cancel";
                });
            }));

        private RelayCommand _CommandDialogCustomButtonException;
        public RelayCommand CommandDialogCustomButtonException => _CommandDialogCustomButtonException ??
            (_CommandDialogCustomButtonException = new RelayCommand(() => {
                _dialog.ShowError(new NotImplementedException(), "title", "buttonText", () => {

                });
            }));

        private RelayCommand _CommandDialogCustomButtonError;
        public RelayCommand CommandDialogCustomButtonError => _CommandDialogCustomButtonError ??
            (_CommandDialogCustomButtonError = new RelayCommand(() => {
                _dialog.ShowError("message", "title", "buttonText", () => {
                });
            }));


        private string _TwoButtonResponse;
        public string TwoButtonResponse {
            get {
                return _TwoButtonResponse;
            }
            set {
                if (_TwoButtonResponse != value) {
                    _TwoButtonResponse = value;
                    RaisePropertyChanged(nameof(TwoButtonResponse));
                }
            }
        }



        private RelayCommand _CommandBackPressed;
        public RelayCommand CommandBackPressed => _CommandBackPressed ??
            (_CommandBackPressed = new RelayCommand(() => {
                _navigation.GoBack();
            }));

    }
}
