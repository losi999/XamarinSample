
using System;
using System.Drawing;

using Foundation;
using UIKit;
using XamarinSample.Core.ViewModel;
using GalaSoft.MvvmLight.Helpers;

namespace XamarinSample.iOS.ViewControllers {
    public partial class MainViewController : ViewControllerBase<IMainViewModel> {
        protected override IMainViewModel ViewModel => Application.Locator.Main;

        public MainViewController(IntPtr handle) : base(handle) {
        }

        public override void DidReceiveMemoryWarning() {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad() {
            base.ViewDidLoad();

            buttonClick.SetCommand(nameof(buttonClick.TouchUpInside), ViewModel.CommandClick);
            buttonSecondPage.SetCommand(nameof(buttonSecondPage.TouchUpInside), ViewModel.CommandSecondPage);

            bindings.Add(this.SetBinding(() => ViewModel.Count, () => labelCount.Text));
        }
    }
}