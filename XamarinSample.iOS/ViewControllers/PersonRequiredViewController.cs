using GalaSoft.MvvmLight.Helpers;
using System;

using UIKit;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.iOS.ViewControllers {
    public partial class PersonRequiredViewController : ViewControllerBase<IPersonRequiredViewModel> {
        protected override IPersonRequiredViewModel ViewModel => Application.Locator.PersonRequired;

        public PersonRequiredViewController(IntPtr handle) : base(handle) {
        }


        public override void DidReceiveMemoryWarning() {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad() {
            base.ViewDidLoad();

            buttonNext.SetCommand(ViewModel.CommandNext);

            bindings.Add(this.SetBinding(() => ViewModel.FirstName, () => textFieldFirstName.Text, BindingMode.TwoWay));
            bindings.Add(this.SetBinding(() => ViewModel.LastName, () => textFieldLastName.Text, BindingMode.TwoWay));
            bindings.Add(this.SetBinding(() => ViewModel.Age, () => textFieldAge.Text, BindingMode.TwoWay).ConvertTargetToSource((text) => {
                int ret = 0;
                int.TryParse(text, out ret);
                return ret;
            }));
            bindings.Add(this.SetBinding(() => ViewModel.Password, () => textFieldPassword.Text, BindingMode.TwoWay));
            bindings.Add(this.SetBinding(() => ViewModel.PasswordConfirm, () => textFieldPasswordConfirm.Text, BindingMode.TwoWay));
        }
    }
}