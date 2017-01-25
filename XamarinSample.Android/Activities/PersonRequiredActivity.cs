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
using XamarinSample.Core.Model.Enum;
using XamarinSample.Android.Converters;

namespace XamarinSample.Android.Activities {
    [Activity(Label = "PersonRequiredActivity")]
    public class PersonRequiredActivity : ActivityBase<IPersonRequiredViewModel> {
        protected override IPersonRequiredViewModel ViewModel => App.Locator.PersonRequired;

        private EditText editTextFirstName => FindViewById<EditText>(Resource.Id.editTextFirstName);
        private EditText editTextLastName => FindViewById<EditText>(Resource.Id.editTextLastName);
        private EditText editTextAge => FindViewById<EditText>(Resource.Id.editTextAge);
        private EditText editTextPassword => FindViewById<EditText>(Resource.Id.editTextPassword);
        private EditText editTextPasswordConfirm => FindViewById<EditText>(Resource.Id.editTextPasswordConfirm);

        private Button buttonNext => FindViewById<Button>(Resource.Id.buttonNext);

        private RadioButton radioButtonMale => FindViewById<RadioButton>(Resource.Id.radioButtonMale);
        private RadioButton radioButtonFemale => FindViewById<RadioButton>(Resource.Id.radioButtonFemale);

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PersonRequired);

            bindings.Add(this.SetBinding(() => ViewModel.FirstName, () => editTextFirstName.Text, BindingMode.TwoWay));
            bindings.Add(this.SetBinding(() => ViewModel.LastName, () => editTextLastName.Text, BindingMode.TwoWay));
            bindings.Add(this.SetBinding(() => ViewModel.Age, () => editTextAge.Text, BindingMode.TwoWay).ConvertTargetToSource(StringToIntConverter.Convert));
            bindings.Add(this.SetBinding(() => ViewModel.Password, () => editTextPassword.Text, BindingMode.TwoWay));
            bindings.Add(this.SetBinding(() => ViewModel.PasswordConfirm, () => editTextPasswordConfirm.Text, BindingMode.TwoWay));

            bindings.Add(this.SetBinding(() => ViewModel.Gender, () => radioButtonMale.Checked, BindingMode.TwoWay)
                .ConvertSourceToTarget(BooleanToMaleConverter.ConvertBack)
                .ConvertTargetToSource(BooleanToMaleConverter.Convert));

            bindings.Add(this.SetBinding(() => ViewModel.Gender, () => radioButtonFemale.Checked, BindingMode.TwoWay)
                .ConvertSourceToTarget(BooleanToFemaleConverter.ConvertBack)
                .ConvertTargetToSource(BooleanToFemaleConverter.Convert));

            buttonNext.SetCommand(ViewModel.CommandNext);
        }
    }
}