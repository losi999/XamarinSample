using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using A = Android;
using Android.Net;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinSample.Android.Activities;
using XamarinSample.Core.ViewModel;
using GalaSoft.MvvmLight.Helpers;
using Android.Provider;
using Java.IO;

namespace XamarinSample.Android.Activities {
    [Activity(Label = "PersonOptionalActivity")]
    public class PersonOptionalActivity : ActivityBase<IPersonOptionalViewModel> {
        protected override IPersonOptionalViewModel ViewModel => App.Locator.PersonOptional;

        private EditText editTextAddress => FindViewById<EditText>(Resource.Id.editTextAddress);
        private EditText editTextEMail => FindViewById<EditText>(Resource.Id.editTextEMail);
        private EditText editTextPhoneNumber => FindViewById<EditText>(Resource.Id.editTextPhoneNumber);

        private ImageView imageViewPhotoPreview => FindViewById<ImageView>(Resource.Id.imageViewPhotoPreview);

        private Button buttonNext => FindViewById<Button>(Resource.Id.buttonNext);
        private Button buttonTakePhoto => FindViewById<Button>(Resource.Id.buttonTakePhoto);

        protected override void OnCreate(A.OS.Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PersonOptional);

            buttonNext.SetCommand(ViewModel.CommandNext);
            buttonTakePhoto.SetCommand(ViewModel.CommandTakePhoto);

            bindings.Add(this.SetBinding(() => ViewModel.Address, () => editTextAddress.Text, BindingMode.TwoWay));
            bindings.Add(this.SetBinding(() => ViewModel.EMail, () => editTextEMail.Text, BindingMode.TwoWay));
            bindings.Add(this.SetBinding(() => ViewModel.PhoneNumber, () => editTextPhoneNumber.Text, BindingMode.TwoWay));

            bindings.Add(this.SetBinding(() => ViewModel.PhotoPath).WhenSourceChanges(() => {
                if (!string.IsNullOrEmpty(ViewModel.PhotoPath)) {
                    var file = new File(ViewModel.PhotoPath);
                    imageViewPhotoPreview.SetImageBitmap(MediaStore.Images.Media.GetBitmap(ContentResolver, A.Net.Uri.FromFile(file)));
                }
            }));
        }
    }
}