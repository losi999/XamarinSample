using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.ViewModel {
    public class ViewModelLocatorBase {

        public ViewModelLocatorBase() {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (!ViewModelBase.IsInDesignModeStatic) {
                SimpleIoc.Default.Register<IMainViewModel, MainViewModel>();
                SimpleIoc.Default.Register<IPersonsViewModel, PersonsViewModel>();
                SimpleIoc.Default.Register<ISettingsViewModel, SettingsViewModel>();
                SimpleIoc.Default.Register<IDialogsViewModel, DialogsViewModel>();
                SimpleIoc.Default.Register<IPersonRequiredViewModel, PersonRequiredViewModel>();
                SimpleIoc.Default.Register<IPersonOptionalViewModel, PersonOptionalViewModel>();
                SimpleIoc.Default.Register<IPersonSummaryViewModel, PersonSummaryViewModel>();
                SimpleIoc.Default.Register<IPersonListViewModel, PersonListViewModel>();
                SimpleIoc.Default.Register<IPersonDetailsViewModel, PersonDetailsViewModel>();
                SimpleIoc.Default.Register<IMapViewModel, MapViewModel>();
                SimpleIoc.Default.Register<ILogInViewModel, LogInViewModel>();
                SimpleIoc.Default.Register<ISignUpViewModel, SignUpViewModel>();
            }

        }


        public IMainViewModel Main => ServiceLocator.Current.GetInstance<IMainViewModel>();
        public IPersonsViewModel Persons => ServiceLocator.Current.GetInstance<IPersonsViewModel>();
        public ISettingsViewModel Settings => ServiceLocator.Current.GetInstance<ISettingsViewModel>();
        public IDialogsViewModel Dialogs => ServiceLocator.Current.GetInstance<IDialogsViewModel>();
        public IPersonRequiredViewModel PersonRequired => ServiceLocator.Current.GetInstance<IPersonRequiredViewModel>();
        public IPersonOptionalViewModel PersonOptional => ServiceLocator.Current.GetInstance<IPersonOptionalViewModel>();
        public IPersonSummaryViewModel PersonSummary => ServiceLocator.Current.GetInstance<IPersonSummaryViewModel>();
        public IPersonListViewModel PersonList => ServiceLocator.Current.GetInstance<IPersonListViewModel>();
        public IPersonDetailsViewModel PersonDetails => ServiceLocator.Current.GetInstance<IPersonDetailsViewModel>();
        public IMapViewModel Map => ServiceLocator.Current.GetInstance<IMapViewModel>();
        public ILogInViewModel LogIn => ServiceLocator.Current.GetInstance<ILogInViewModel>();
        public ISignUpViewModel SignUp => ServiceLocator.Current.GetInstance<ISignUpViewModel>();
    }
}
