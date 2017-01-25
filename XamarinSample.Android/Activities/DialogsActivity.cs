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
    [Activity(Label = "DialogsActivity")]
    public class DialogsActivity : ActivityBase<IDialogsViewModel> {
        protected override IDialogsViewModel ViewModel => App.Locator.Dialogs;

        private Button buttonDialogOkButton => FindViewById<Button>(Resource.Id.buttonDialogOkButton);
        private Button buttonDialogCustomButton => FindViewById<Button>(Resource.Id.buttonDialogCustomButton);
        private Button buttonDialogCustomTwoButton => FindViewById<Button>(Resource.Id.buttonDialogCustomTwoButton);
        private Button buttonDialogCustomButtonError => FindViewById<Button>(Resource.Id.buttonDialogCustomButtonError);
        private Button buttonDialogCustomButtonException => FindViewById<Button>(Resource.Id.buttonDialogCustomButtonException);

        private TextView textViewTwoButtonResponse => FindViewById<TextView>(Resource.Id.textViewTwoButtonResponse);

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Dialogs);

            bindings.Add(this.SetBinding(() => ViewModel.TwoButtonResponse, () => textViewTwoButtonResponse.Text));

            buttonDialogOkButton.SetCommand(ViewModel.CommandDialogOkButton);
            buttonDialogCustomButton.SetCommand(ViewModel.CommandDialogCustomButton);
            buttonDialogCustomButtonError.SetCommand(ViewModel.CommandDialogCustomButtonError);
            buttonDialogCustomButtonException.SetCommand(ViewModel.CommandDialogCustomButtonException);
            buttonDialogCustomTwoButton.SetCommand(ViewModel.CommandDialogCustomTwoButton);

        }
    }
}