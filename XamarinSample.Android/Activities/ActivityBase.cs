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
using GalaSoft.MvvmLight;
using XamarinSample.BackEnd.ViewModel;
using GalaSoft.MvvmLight.Views;
using GalaSoft.MvvmLight.Helpers;

namespace XamarinSample.Android.Activities {
    public abstract class ActivityBase<T> : ActivityBase where T : ViewModelBase {
        protected abstract T ViewModel { get; }
        protected List<Binding> bindings = new List<Binding>();

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
    }
}