using Android.App;
using Android.Widget;
using Android.OS;
using GalaSoft.MvvmLight.Helpers;
using XamarinSample.Android.Activities;
using GalaSoft.MvvmLight;
using System;
using XamarinSample.ViewModel;
using System.Collections.Generic;
using Android.Views;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.Android.Activities {

    [Activity(Label = "XamarinSample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ActivityBase<IMainViewModel> {

        private Button buttonDialogs => FindViewById<Button>(Resource.Id.buttonDialogs);
        private Button buttonPersons => FindViewById<Button>(Resource.Id.buttonPersons);
        private Button buttonSettings => FindViewById<Button>(Resource.Id.buttonSettings);
        private Button buttonMap => FindViewById<Button>(Resource.Id.buttonMap);

        protected override IMainViewModel ViewModel => App.Locator.Main;

        protected override void OnCreate(Bundle bundle) {

            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            buttonDialogs.SetCommand(ViewModel.CommandDialogsPage);
            buttonPersons.SetCommand(ViewModel.CommandPersonsPage);
            buttonSettings.SetCommand(ViewModel.CommandSettingsPage);
            buttonMap.SetCommand(ViewModel.CommandMapPage);

        }

    }
}

