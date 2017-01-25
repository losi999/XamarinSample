using GalaSoft.MvvmLight.Helpers;
using System;

using UIKit;
using XamarinSample.Core.ViewModel;
using XamarinSample.iOS.ViewControllers;

namespace XamarinSample.iOS.ViewControllers {
    public partial class MapViewController : ViewControllerBase<IMapViewModel> {
        protected override IMapViewModel ViewModel => Application.Locator.Map;

        public MapViewController(IntPtr handle) : base(handle) {
        }

        public override void DidReceiveMemoryWarning() {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad() {
            base.ViewDidLoad();

            buttonCurrentLocation.SetCommand(ViewModel.CommandGetCurrentPosition);

            buttonPointsInArea.SetCommand(ViewModel.CommandGetPointsInArea);
            bindings.Add(this.SetBinding(() => ViewModel.IsAreaButtonEnabled, () => buttonPointsInArea.Enabled));

            buttonDirections.SetCommand(ViewModel.CommandGetDirections);
            bindings.Add(this.SetBinding(() => ViewModel.IsAreaButtonEnabled, () => buttonDirections.Enabled));

            buttonMapsApplication.SetCommand(ViewModel.CommandOpenMapsApp);
            bindings.Add(this.SetBinding(() => ViewModel.IsAreaButtonEnabled, () => buttonMapsApplication.Enabled));
        }
    }
}