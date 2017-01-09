using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.ViewModel;
using XamarinSample.Core.Services;
using XamarinSample.WindowsPhone81.View;

namespace XamarinSample.WindowsPhone81.Services {
    public class NavigationService : GalaSoft.MvvmLight.Views.NavigationService, INavigationService {

        public NavigationService() {
            Configure(nameof(SecondViewModel), typeof(SecondPage));
        }

        public void NavigateToSecond(params object[] parameters) {
            NavigateTo(nameof(SecondViewModel), parameters);
        }
    }
}
