using GalaSoft.MvvmLight.Helpers;
using System;

using UIKit;
using XamarinSample.Core.ViewModel;
using XamarinSample.iOS.Converters;

namespace XamarinSample.iOS.ViewControllers {
    public partial class PersonDetailsViewController : ViewControllerBase<IPersonDetailsViewModel> {
        protected override IPersonDetailsViewModel ViewModel => Application.Locator.PersonDetails;

        public PersonDetailsViewController(IntPtr handle) : base(handle) {
        }

        public override void DidReceiveMemoryWarning() {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad() {
            base.ViewDidLoad();

            buttonDeletePerson.SetCommand(ViewModel.CommandDeletePerson);

            buttonSendEMail.SetCommand(ViewModel.CommandSendEMail);
            bindings.Add(this.SetBinding(() => ViewModel.EMail, () => buttonSendEMail.Hidden).ConvertSourceToTarget(StringToInverseBooleanConverter.Convert));

            buttonDial.SetCommand(ViewModel.CommandDial);
            bindings.Add(this.SetBinding(() => ViewModel.PhoneNumber, () => buttonDial.Hidden).ConvertSourceToTarget(StringToInverseBooleanConverter.Convert));

            buttonShowOnMap.SetCommand(ViewModel.CommandShowOnMap);
            bindings.Add(this.SetBinding(() => ViewModel.Address, () => buttonShowOnMap.Hidden).ConvertSourceToTarget(StringToInverseBooleanConverter.Convert));

            bindings.Add(this.SetBinding(() => ViewModel.Name, () => labelName.Text));
            bindings.Add(this.SetBinding(() => ViewModel.Age, () => labelAge.Text));
            bindings.Add(this.SetBinding(() => ViewModel.Gender, () => labelGender.Text).ConvertSourceToTarget((gender) => { return gender.ToString(); }));

            bindings.Add(this.SetBinding(() => ViewModel.Address, () => labelAddress.Text));
            bindings.Add(this.SetBinding(() => ViewModel.Address, () => labelAddress.Hidden).ConvertSourceToTarget(StringToInverseBooleanConverter.Convert));

            bindings.Add(this.SetBinding(() => ViewModel.EMail, () => labelEMail.Text));
            bindings.Add(this.SetBinding(() => ViewModel.EMail, () => labelEMail.Hidden).ConvertSourceToTarget(StringToInverseBooleanConverter.Convert));

            bindings.Add(this.SetBinding(() => ViewModel.PhoneNumber, () => labelPhoneNumber.Text));
            bindings.Add(this.SetBinding(() => ViewModel.PhoneNumber, () => labelPhoneNumber.Hidden).ConvertSourceToTarget(StringToInverseBooleanConverter.Convert));
        }
    }
}