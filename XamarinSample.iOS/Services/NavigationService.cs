using System;
using System.Collections.Generic;
using System.Text;
using XamarinSample.Core.Services;
using XamarinSample.ViewModel;

namespace XamarinSample.iOS.Services {
    public class NavigationService : GalaSoft.MvvmLight.Views.NavigationService, INavigationService {
        public NavigationService() {
            Configure(nameof(SecondViewModel), "Second");
        }

        public void NavigateToSecond(params object[] parameters) {
            NavigateTo(nameof(SecondViewModel));
        }
    }
}
