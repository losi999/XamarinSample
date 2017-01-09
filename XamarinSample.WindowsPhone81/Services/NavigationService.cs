using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.BackEnd.ViewModel;
using XamarinSample.Core.Services;
using XamarinSample.WindowsPhone8.View;

namespace XamarinSample.WindowsPhone8.Services {
    public class NavigationService : GalaSoft.MvvmLight.Views.NavigationService, INavigationService {

        public NavigationService() {
            Configure(nameof(SecondViewModel), typeof(SecondPage));
        }

        public void NavigateToSecond(params object[] parameters) {
            NavigateTo(nameof(SecondViewModel), parameters);
        }
    }
}
