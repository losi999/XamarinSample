using GalaSoft.MvvmLight.Helpers;
using System;

using UIKit;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.iOS.ViewControllers {
    public partial class PersonSummaryViewController : ViewControllerBase<IPersonSummaryViewModel> {
        protected override IPersonSummaryViewModel ViewModel => Application.Locator.PersonSummary;

        public PersonSummaryViewController(IntPtr handle) : base(handle) {
        }


        public override void DidReceiveMemoryWarning() {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad() {
            base.ViewDidLoad();

            buttonSave.SetCommand(ViewModel.CommandSave);

            bindings.Add(this.SetBinding(() => ViewModel.SummaryText, () => labelSummary.Text));
            bindings.Add(this.SetBinding(() => ViewModel.Password, () => textFieldPassword.Text, BindingMode.TwoWay));
        }
    }
}