using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinSample.Core.ViewModel;
using GalaSoft.MvvmLight.Helpers;

namespace XamarinSample.Android.Activities {
    [Activity(Label = "MapActivity")]
    public class MapActivity : ActivityBase<IMapViewModel> {
        protected override IMapViewModel ViewModel => App.Locator.Map;

        private Button buttonCurrentLocation => FindViewById<Button>(Resource.Id.buttonCurrentLocation);
        private Button buttonPointsInArea => FindViewById<Button>(Resource.Id.buttonPointsInArea);
        private Button buttonDirections => FindViewById<Button>(Resource.Id.buttonDirections);
        private Button buttonMapsApplication => FindViewById<Button>(Resource.Id.buttonMapsApplication);

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Map);

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