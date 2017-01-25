using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using XamarinSample.Common.Services;
using XamarinSample.iOS.ViewControllers;
using GS = GalaSoft.MvvmLight.Views;

namespace XamarinSample.iOS.Services {
    public class NavigationService : NavigationServiceBase {
        public const string Storyboard = "Story";
        public const string Navigation = "Navigation";

        private GS.NavigationService _navigation;

        public NavigationService(GS.NavigationService navigation) {
            _navigation = navigation;

            var controller = (UINavigationController)((AppDelegate)UIApplication.SharedApplication.Delegate).Window.RootViewController;
            _navigation.Initialize(controller);

            _navigation.Configure(Dialogs, Dialogs);
            _navigation.Configure(Settings, Settings);
            _navigation.Configure(Persons, Persons);
            _navigation.Configure(PersonRequired, PersonRequired);
            _navigation.Configure(PersonOptional, PersonOptional);
            _navigation.Configure(PersonSummary, PersonSummary);
            _navigation.Configure(PersonList, PersonList);
            _navigation.Configure(PersonDetails, PersonDetails);
            _navigation.Configure(Map, Map);
        }

        public override string CurrentPageKey => _navigation.CurrentPageKey;
        public override void GoBack() => _navigation.GoBack();
        public override void NavigateTo(string pageKey) => _navigation.NavigateTo(pageKey);
        public override void NavigateTo(string pageKey, object parameter) => _navigation.NavigateTo(pageKey, parameter);

        public override void NavigateBackToPersonsPage() {
            RemoveFromStack<PersonsViewController>();
            base.NavigateBackToPersonsPage();
        }

        protected override void RemoveFromStack<T>() {
            var temp = _navigation.NavigationController.ViewControllers.ToList();
            while (true) {
                var prev = temp[temp.Count - 2];
                if (prev is T) {
                    break;
                }
                temp.Remove(prev);
            }
            _navigation.NavigationController.ViewControllers = temp.ToArray();
        }

    }
}
