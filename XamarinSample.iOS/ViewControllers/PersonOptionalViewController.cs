using GalaSoft.MvvmLight.Helpers;
using System;

using UIKit;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.iOS.ViewControllers {
    public partial class PersonOptionalViewController : ViewControllerBase<IPersonOptionalViewModel> {
        protected override IPersonOptionalViewModel ViewModel => Application.Locator.PersonOptional;

        public PersonOptionalViewController(IntPtr handle) : base(handle) {
        }


        public override void DidReceiveMemoryWarning() {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad() {
            base.ViewDidLoad();

            buttonNext.SetCommand(ViewModel.CommandNext);
            buttonTakePhoto.SetCommand(ViewModel.CommandTakePhoto);

            bindings.Add(this.SetBinding(() => ViewModel.Address, () => textFieldAddress.Text, BindingMode.TwoWay));
            bindings.Add(this.SetBinding(() => ViewModel.EMail, () => textFieldEMail.Text, BindingMode.TwoWay));
            bindings.Add(this.SetBinding(() => ViewModel.PhoneNumber, () => textFieldPhoneNumber.Text, BindingMode.TwoWay));
        }
    }
}