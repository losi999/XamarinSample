using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Services;

namespace XamarinSample.Common.Services {
    public abstract class NavigationServiceBase : INavigationService {
        protected const string Dialogs = "Dialogs";
        protected const string Settings = "Settings";
        protected const string Persons = "Persons";
        protected const string Map = "Map";
        protected const string PersonRequired = "PersonRequired";
        protected const string PersonOptional = "PersonOptional";
        protected const string PersonSummary = "PersonSummary";
        protected const string PersonList = "PersonList";
        protected const string PersonDetails = "PersonDetails";
        protected const string LogIn = "LogIn";
        protected const string SignUp = "SignUp";

        public abstract string CurrentPageKey { get; }
        public abstract void GoBack();
        public abstract void NavigateTo(string pageKey);
        public abstract void NavigateTo(string pageKey, object parameter);


        protected abstract void RemoveFromStack<T>();


        public virtual void NavigateBackToPersonsPage() {
            GoBack();
        }

        public void NavigateToDialogsPage() {
            NavigateTo(Dialogs);
        }

        public void NavigateToPersonOptionalPage() {
            NavigateTo(PersonOptional);
        }

        public void NavigateToPersonRequiredPage() {
            NavigateTo(PersonRequired);
        }

        public void NavigateToPersonsPage() {
            NavigateTo(Persons);
        }

        public void NavigateToSettingsPage() {
            NavigateTo(Settings);
        }

        public void NavigateToPersonSummaryPage() {
            NavigateTo(PersonSummary);
        }

        public void NavigateToPersonListPage() {
            NavigateTo(PersonList);
        }

        public void NavigateToMapPage() {
            NavigateTo(Map);
        }

        public void NavigateToPersonDetailsPage() {
            NavigateTo(PersonDetails);
        }

        public void NavigateToLogInPage() {
            NavigateTo(LogIn);
        }

        public void NavigateToSignUpPage() {
            NavigateTo(SignUp);
        }
    }
}
