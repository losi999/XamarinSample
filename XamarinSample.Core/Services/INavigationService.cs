using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSample.Core.Services {
    public interface INavigationService : GalaSoft.MvvmLight.Views.INavigationService {
        void NavigateToDialogsPage();
        void NavigateToSettingsPage();
        void NavigateToPersonsPage();
        void NavigateBackToPersonsPage();
        void NavigateToPersonRequiredPage();
        void NavigateToPersonOptionalPage();
        void NavigateToPersonSummaryPage();
        void NavigateToPersonListPage();
        void NavigateToMapPage();
        void NavigateToPersonDetailsPage();
        void NavigateToLogInPage();
        void NavigateToSignUpPage();
    }
}
