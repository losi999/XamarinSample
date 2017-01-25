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
    [Activity(Label = "PersonsActivity")]
    public class PersonsActivity : ActivityBase<IPersonsViewModel> {
        protected override IPersonsViewModel ViewModel => App.Locator.Persons;

        private Button buttonNewPerson => FindViewById<Button>(Resource.Id.buttonNewPerson);
        private Button buttonListPersons => FindViewById<Button>(Resource.Id.buttonListPersons);

        private TextView textViewCount => FindViewById<TextView>(Resource.Id.textViewCount);

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Persons);

            buttonNewPerson.SetCommand(ViewModel.CommandNewPerson);
            buttonListPersons.SetCommand(ViewModel.CommandListPersons);

            bindings.Add(this.SetBinding(() => ViewModel.PersonCount, () => textViewCount.Text));
        }
    }
}