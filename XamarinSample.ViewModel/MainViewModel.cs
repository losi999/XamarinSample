using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Services;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.ViewModel {
    public class MainViewModel : ViewModelBase, IMainViewModel {

        private readonly INavigationService _navigation;

        public MainViewModel(INavigationService navigation) {
            _navigation = navigation;
        }

        private RelayCommand _CommandBackPressed;
        public RelayCommand CommandBackPressed => _CommandBackPressed ??
            (_CommandBackPressed = new RelayCommand(() => {
            }));

        private RelayCommand _CommandMapPage;
        public RelayCommand CommandMapPage => _CommandMapPage ??
            (_CommandMapPage = new RelayCommand(() => {
                _navigation.NavigateToMapPage();
            }));

        private RelayCommand _CommandDialogsPage;
        public RelayCommand CommandDialogsPage => _CommandDialogsPage ??
            (_CommandDialogsPage = new RelayCommand(() => {
                _navigation.NavigateToDialogsPage();
            }));

        private RelayCommand _CommandSettingsPage;
        public RelayCommand CommandSettingsPage => _CommandSettingsPage ??
            (_CommandSettingsPage = new RelayCommand(() => {
                _navigation.NavigateToSettingsPage();
            }));

        private RelayCommand _CommandPersonsPage;
        public RelayCommand CommandPersonsPage => _CommandPersonsPage ??
            (_CommandPersonsPage = new RelayCommand(() => {
                _navigation.NavigateToPersonsPage();
            }));

        private RelayCommand _CommandLoginPage;
        public RelayCommand CommandLoginPage => _CommandLoginPage ??
            (_CommandLoginPage = new RelayCommand(() => {
                _navigation.NavigateToLogInPage();
            }));
    }
}
