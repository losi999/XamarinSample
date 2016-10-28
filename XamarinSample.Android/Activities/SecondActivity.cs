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
using XamarinSample.Android.Activities;
using XamarinSample.Core.ViewModel;
using GalaSoft.MvvmLight.Helpers;

namespace XamarinSample.Android.Activities {
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : ActivityBase<SecondViewModel> {
        protected override SecondViewModel ViewModel => App.Locator.Second;

        public Button buttonDialog => FindViewById<Button>(Resource.Id.buttonDialog);
        public Button buttonDownloadJson => FindViewById<Button>(Resource.Id.buttonDownloadJson);
        public TextView textViewDialodResponse => FindViewById<TextView>(Resource.Id.textViewDialogResponse);

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.Second);

            bindings.Add(this.SetBinding(() => ViewModel.DialogResponse, () => textViewDialodResponse.Text));

            buttonDialog.SetCommand(ViewModel.CommandDialog);
            buttonDownloadJson.SetCommand(ViewModel.CommandJson);
        }
    }
}