using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Windows10.View;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using GS = GalaSoft.MvvmLight.Views;
using XamarinSample.Common.Services;

namespace XamarinSample.Windows10.Services {
    public class NavigationService : NavigationServiceBase {
        private GS.NavigationService _navigation;

        public NavigationService(GS.NavigationService navigation) {
            _navigation = navigation;

            _navigation.Configure(Dialogs, typeof(DialogsPage));
            _navigation.Configure(Settings, typeof(SettingsPage));
            _navigation.Configure(Persons, typeof(PersonsPage));
            _navigation.Configure(PersonRequired, typeof(PersonRequiredPage));
            _navigation.Configure(PersonOptional, typeof(PersonOptionalPage));
            _navigation.Configure(PersonSummary, typeof(PersonSummaryPage));
            _navigation.Configure(PersonList, typeof(PersonListPage));
            _navigation.Configure(PersonDetails, typeof(PersonDetailsPage));
            _navigation.Configure(Map, typeof(MapPage));
            _navigation.Configure(LogIn, typeof(LogInPage));
            _navigation.Configure(SignUp, typeof(SignUpPage));
        }

        public override string CurrentPageKey => _navigation.CurrentPageKey;
        public override void GoBack() => _navigation.GoBack();
        public override void NavigateTo(string pageKey) => _navigation.NavigateTo(pageKey);
        public override void NavigateTo(string pageKey, object parameter) => _navigation.NavigateTo(pageKey, parameter);


        public override void NavigateBackToPersonsPage() {
            RemoveFromStack<PersonsPage>();
            base.NavigateBackToPersonsPage();
        }

        protected override void RemoveFromStack<T>() {
            Frame rootFrame = Window.Current.Content as Frame;
            while (true) {
                var last = rootFrame.BackStack.LastOrDefault();
                if (last.SourcePageType == typeof(T)) {
                    break;
                }
                rootFrame.BackStack.Remove(last);
            }
        }
    }
}
