using Android.App;
using Android.Widget;
using Android.OS;
using GalaSoft.MvvmLight.Helpers;
using XamarinSample.Android.Activities;
using GalaSoft.MvvmLight;
using System;
using XamarinSample.Core.ViewModel;
using System.Collections.Generic;
using Android.Views;

namespace XamarinSample.Android.Activities {
    [Activity(Label = "XamarinSample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ActivityBase<MainViewModel> {

        public Button buttonClick => FindViewById<Button>(Resource.Id.buttonClick);
        public Button buttonSecondPage => FindViewById<Button>(Resource.Id.buttonSecondPage);
        public TextView textViewCount => FindViewById<TextView>(Resource.Id.textViewCount);

        protected override MainViewModel ViewModel => App.Locator.Main;

        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.Main);

            buttonClick.SetCommand(ViewModel.CommandClick);
            buttonSecondPage.SetCommand(ViewModel.CommandSecondPage);

            bindings.Add(this.SetBinding(() => ViewModel.Count, () => textViewCount.Text));
        }

    }
}

