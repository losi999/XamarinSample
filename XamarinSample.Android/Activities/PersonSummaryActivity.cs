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
using Android.Provider;
using Java.IO;

namespace XamarinSample.Android.Activities {
    [Activity(Label = "PersonSummaryActivity")]
    public class PersonSummaryActivity : ActivityBase<IPersonSummaryViewModel> {
        protected override IPersonSummaryViewModel ViewModel => App.Locator.PersonSummary;

        private TextView textViewSummary => FindViewById<TextView>(Resource.Id.textViewSummary);

        private ImageView imageViewPhotoPreview => FindViewById<ImageView>(Resource.Id.imageViewPhotoPreview);

        private EditText editTextPassword => FindViewById<EditText>(Resource.Id.editTextPassword);

        private Button buttonSave => FindViewById<Button>(Resource.Id.buttonSave);

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.PersonSummary);

            buttonSave.SetCommand(ViewModel.CommandSave);

            bindings.Add(this.SetBinding(() => ViewModel.SummaryText, () => textViewSummary.Text));
            bindings.Add(this.SetBinding(() => ViewModel.Password, () => editTextPassword.Text, BindingMode.TwoWay));

            bindings.Add(this.SetBinding(() => ViewModel.PhotoPath).WhenSourceChanges(() => {
                if (!string.IsNullOrEmpty(ViewModel.PhotoPath)) {
                    var file = new File(ViewModel.PhotoPath);
                    imageViewPhotoPreview.SetImageBitmap(MediaStore.Images.Media.GetBitmap(ContentResolver, A.Net.Uri.FromFile(file)));
                }
            }));
        }
    }
}