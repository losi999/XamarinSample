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
using XamarinSample.Core.Services;
using XamarinSample.ViewModel;
using XamarinSample.Android.Activities;

namespace XamarinSample.Android.Services {
    public class NavigationService : GalaSoft.MvvmLight.Views.NavigationService, INavigationService {

        public NavigationService() {
            Configure(nameof(SecondViewModel), typeof(SecondActivity));
        }

        public void NavigateToSecond(params object[] parameters) {
            NavigateTo(nameof(SecondViewModel), parameters);
        }
    }
}