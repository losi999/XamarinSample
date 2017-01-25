using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using A = Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinSample.Core.ViewModel;
using GalaSoft.MvvmLight.Helpers;
using XamarinSample.Android.Converters;
using Android.Provider;
using Java.IO;

namespace XamarinSample.Android.Activities {
    [Activity(Label = "PersonDetailsActivity")]
    public class PersonDetailsActivity : ActivityBase<IPersonDetailsViewModel> {
        protected override IPersonDetailsViewModel ViewModel => App.Locator.PersonDetails;

        private TextView textViewName => FindViewById<TextView>(Resource.Id.textViewName);
        private TextView textViewAge => FindViewById<TextView>(Resource.Id.textViewAge);
        private TextView textViewGender => FindViewById<TextView>(Resource.Id.textViewGender);
        private TextView textViewAddress => FindViewById<TextView>(Resource.Id.textViewAddress);
        private TextView textViewEMail => FindViewById<TextView>(Resource.Id.textViewEMail);
        private TextView textViewPhoneNumber => FindViewById<TextView>(Resource.Id.textViewPhoneNumber);

        private Button buttonDeletePerson => FindViewById<Button>(Resource.Id.buttonDeletePerson);

        private ImageView imageViewPhotoPreview => FindViewById<ImageView>(Resource.Id.imageViewPhotoPreview);

        private Button buttonSendEMail => FindViewById<Button>(Resource.Id.buttonSendEMail);
        private Button buttonDial => FindViewById<Button>(Resource.Id.buttonDial);
        private Button buttonShowOnMap => FindViewById<Button>(Resource.Id.buttonShowOnMap);

        private LinearLayout layoutAddress => FindViewById<LinearLayout>(Resource.Id.layoutAddress);
        private LinearLayout layoutEMail => FindViewById<LinearLayout>(Resource.Id.layoutEMail);
        private LinearLayout layoutPhoneNumber => FindViewById<LinearLayout>(Resource.Id.layoutPhoneNumber);

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PersonDetails);

            buttonDeletePerson.SetCommand(ViewModel.CommandDeletePerson);

            buttonSendEMail.SetCommand(ViewModel.CommandSendEMail);
            bindings.Add(this.SetBinding(() => ViewModel.EMail, () => buttonSendEMail.Visibility).ConvertSourceToTarget(StringToVisibilityConverter.Convert));

            buttonDial.SetCommand(ViewModel.CommandDial);
            bindings.Add(this.SetBinding(() => ViewModel.PhoneNumber, () => buttonDial.Visibility).ConvertSourceToTarget(StringToVisibilityConverter.Convert));

            buttonShowOnMap.SetCommand(ViewModel.CommandShowOnMap);
            bindings.Add(this.SetBinding(() => ViewModel.Address, () => buttonShowOnMap.Visibility).ConvertSourceToTarget(StringToVisibilityConverter.Convert));

            bindings.Add(this.SetBinding(() => ViewModel.Name, () => textViewName.Text));
            bindings.Add(this.SetBinding(() => ViewModel.Age, () => textViewAge.Text));
            bindings.Add(this.SetBinding(() => ViewModel.Gender, () => textViewGender.Text).ConvertSourceToTarget((gender) => { return gender.ToString(); }));

            bindings.Add(this.SetBinding(() => ViewModel.Address, () => textViewAddress.Text));
            bindings.Add(this.SetBinding(() => ViewModel.Address, () => layoutAddress.Visibility).ConvertSourceToTarget(StringToVisibilityConverter.Convert));

            bindings.Add(this.SetBinding(() => ViewModel.EMail, () => textViewEMail.Text));
            bindings.Add(this.SetBinding(() => ViewModel.EMail, () => layoutEMail.Visibility).ConvertSourceToTarget(StringToVisibilityConverter.Convert));

            bindings.Add(this.SetBinding(() => ViewModel.PhoneNumber, () => textViewPhoneNumber.Text));
            bindings.Add(this.SetBinding(() => ViewModel.PhoneNumber, () => layoutPhoneNumber.Visibility).ConvertSourceToTarget(StringToVisibilityConverter.Convert));



            bindings.Add(this.SetBinding(() => ViewModel.PhotoPath).WhenSourceChanges(() => {
                if (!string.IsNullOrEmpty(ViewModel.PhotoPath)) {
                    var file = new File(ViewModel.PhotoPath);
                    imageViewPhotoPreview.SetImageBitmap(MediaStore.Images.Media.GetBitmap(ContentResolver, A.Net.Uri.FromFile(file)));
                }
            }));
        }
    }
}