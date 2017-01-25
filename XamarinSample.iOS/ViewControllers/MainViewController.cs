
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
            base.DidReceiveMemoryWarning();

        }

        public override void ViewDidLoad() {
            base.ViewDidLoad();

            buttonDialogs.SetCommand(ViewModel.CommandDialogsPage);
            buttonPersons.SetCommand(ViewModel.CommandPersonsPage);
            buttonSettings.SetCommand(ViewModel.CommandSettingsPage);
            buttonMap.SetCommand(ViewModel.CommandMapPage);

        }
    }
}