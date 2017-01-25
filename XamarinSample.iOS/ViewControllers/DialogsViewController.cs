using Foundation;
using GalaSoft.MvvmLight.Helpers;
using System;
using UIKit;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.iOS.ViewControllers {
    public partial class DialogsViewController : ViewControllerBase<IDialogsViewModel> {
        protected override IDialogsViewModel ViewModel => Application.Locator.Dialogs;

        public DialogsViewController(IntPtr handle) : base(handle) {
        }

        public override void ViewDidLoad() {
            base.ViewDidLoad();

            bindings.Add(this.SetBinding(() => ViewModel.TwoButtonResponse, () => labelTwoButtonResponse.Text));

            buttonDialogOkButton.SetCommand(ViewModel.CommandDialogOkButton);
            buttonDialogCustomButton.SetCommand(ViewModel.CommandDialogCustomButton);
            buttonDialogCustomButtonError.SetCommand(ViewModel.CommandDialogCustomButtonError);
            buttonDialogCustomButtonException.SetCommand(ViewModel.CommandDialogCustomButtonException);
            buttonDialogCustomTwoButton.SetCommand(ViewModel.CommandDialogCustomTwoButton);
        }
    }
}