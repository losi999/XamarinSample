using GalaSoft.MvvmLight.Helpers;
using System;

using UIKit;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.iOS.ViewControllers {
    public partial class PersonsViewController : ViewControllerBase<IPersonsViewModel> {
        protected override IPersonsViewModel ViewModel => Application.Locator.Persons;

        public PersonsViewController(IntPtr handle) : base(handle) {
        }

        public override void DidReceiveMemoryWarning() {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad() {
            base.ViewDidLoad();

            buttonNewPerson.SetCommand(ViewModel.CommandNewPerson);
            buttonListPersons.SetCommand(ViewModel.CommandListPersons);

            bindings.Add(this.SetBinding(() => ViewModel.PersonCount, () => labelPersonCount.Text));
        }
    }
}