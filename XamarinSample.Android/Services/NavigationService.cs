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
using XamarinSample.Android.Activities;
using GS = GalaSoft.MvvmLight.Views;
using XamarinSample.Common.Services;

namespace XamarinSample.Android.Services {
    public class NavigationService : NavigationServiceBase {
        private GS.NavigationService _navigation;

        public NavigationService(GS.NavigationService navigation) {
            _navigation = navigation;

            _navigation.Configure(Dialogs, typeof(DialogsActivity));
            _navigation.Configure(Settings, typeof(SettingsActivity));
            _navigation.Configure(Persons, typeof(PersonsActivity));
            _navigation.Configure(PersonRequired, typeof(PersonRequiredActivity));
            _navigation.Configure(PersonOptional, typeof(PersonOptionalActivity));
            _navigation.Configure(PersonSummary, typeof(PersonSummaryActivity));
            _navigation.Configure(PersonList, typeof(PersonListActivity));
            _navigation.Configure(PersonDetails, typeof(PersonDetailsActivity));
            _navigation.Configure(Map, typeof(MapActivity));
        }

        public override string CurrentPageKey => _navigation.CurrentPageKey;
        public override void GoBack() => _navigation.GoBack();
        public override void NavigateTo(string pageKey) => _navigation.NavigateTo(pageKey);
        public override void NavigateTo(string pageKey, object parameter) => _navigation.NavigateTo(pageKey, parameter);


        public override void NavigateBackToPersonsPage() {
            RemoveFromStack<PersonsActivity>();
            base.NavigateBackToPersonsPage();
        }

        protected override void RemoveFromStack<T>() {
            while (true) {
                var prev = App.BackStack.Pop();
                if (prev is T) {
                    break;
                }
                prev.Finish();
            }
        }
    }
}