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
using XamarinSample.Core.Model.ItemModels;
using XamarinSample.Core.Model.Enum;
using XamarinSample.Android.Converters;

namespace XamarinSample.Android.Activities {
    [Activity(Label = "PersonListActivity")]
    public class PersonListActivity : ActivityBase<IPersonListViewModel> {
        protected override IPersonListViewModel ViewModel => App.Locator.PersonList;

        private ListView listViewPersons => FindViewById<ListView>(Resource.Id.listViewPersons);

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PersonList);

            listViewPersons.Adapter = ViewModel.Persons.GetAdapter(GetPersonsAdapter);
        }

        protected override void OnResume() {
            base.OnResume();
            ViewModel.CommandLoaded.Execute(null);
        }

        private View GetPersonsAdapter(int position, PersonItemModel item, View view) {
            view = LayoutInflater.Inflate(Resource.Layout.PersonListRow, null);
            LinearLayout layout = view as LinearLayout;

            var textViewName = layout.FindViewById<TextView>(Resource.Id.textViewName);
            var textViewAge = layout.FindViewById<TextView>(Resource.Id.textViewAge);
            var textViewGender = layout.FindViewById<TextView>(Resource.Id.textViewGender);
            var textViewAddress = layout.FindViewById<TextView>(Resource.Id.textViewAddress);
            var textViewEMail = layout.FindViewById<TextView>(Resource.Id.textViewEMail);
            var textViewPhoneNumber = layout.FindViewById<TextView>(Resource.Id.textViewPhoneNumber);

            var layoutAddress = layout.FindViewById<LinearLayout>(Resource.Id.layoutAddress);
            var layoutEMail = layout.FindViewById<LinearLayout>(Resource.Id.layoutEMail);
            var layoutPhoneNumber = layout.FindViewById<LinearLayout>(Resource.Id.layoutPhoneNumber);

            bindings.Add(new Binding<string, string>(item, () => item.Name, textViewName, () => textViewName.Text));
            bindings.Add(new Binding<int, string>(item, () => item.Age, textViewAge, () => textViewAge.Text));
            bindings.Add(new Binding<Gender, string>(item, () => item.Gender, textViewGender, () => textViewGender.Text).ConvertSourceToTarget((gender) => { return gender.ToString(); }));

            bindings.Add(new Binding<string, string>(item, () => item.Address, textViewAddress, () => textViewAddress.Text));
            bindings.Add(new Binding<string, ViewStates>(item, () => item.Address, layoutAddress, () => layoutAddress.Visibility).ConvertSourceToTarget(StringToVisibilityConverter.Convert));



            bindings.Add(new Binding<string, string>(item, () => item.EMail, textViewEMail, () => textViewEMail.Text));
            bindings.Add(new Binding<string, ViewStates>(item, () => item.Address, layoutEMail, () => layoutEMail.Visibility).ConvertSourceToTarget(StringToVisibilityConverter.Convert));



            bindings.Add(new Binding<string, string>(item, () => item.PhoneNumber, textViewPhoneNumber, () => textViewPhoneNumber.Text));
            bindings.Add(new Binding<string, ViewStates>(item, () => item.Address, layoutPhoneNumber, () => layoutPhoneNumber.Visibility).ConvertSourceToTarget(StringToVisibilityConverter.Convert));

            layout.SetCommand("Click", item.CommandPersonDetails, item.Id);

            return layout;
        }
    }
}