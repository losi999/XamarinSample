using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Services;
using XamarinSample.Core.ViewModel;
using XamarinSample.Windows.View;

namespace XamarinSample.Windows.Services {
    public class NavigationService : GalaSoft.MvvmLight.Views.NavigationService, INavigationService {

        public NavigationService() {
            Configure(nameof(SecondViewModel), typeof(SecondPage));
        }

        public void NavigateToSecond(params object[] parameters) {
            NavigateTo(nameof(SecondViewModel), parameters);
        }
    }
}
