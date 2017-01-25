using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Common.Services;
using XamarinSample.Core.Services;
using XamarinSample.Core.ViewModel;
using XamarinSample.WindowsPhone81.Services;
using GS = GalaSoft.MvvmLight.Views;
using D = XamarinSample.DesignViewModel;

namespace XamarinSample.WindowsPhone81 {
    public class ViewModelLocator : ViewModel.ViewModelLocator {
        public ViewModelLocator() {

            if (ViewModelBase.IsInDesignModeStatic) {
                SimpleIoc.Default.Register<IDesignDataService, DesignDataService>();

                SimpleIoc.Default.Register<IMainViewModel, D.MainViewModel>();
                SimpleIoc.Default.Register<IPersonsViewModel, D.PersonsViewModel>();
                SimpleIoc.Default.Register<ISettingsViewModel, D.SettingsViewModel>();
                SimpleIoc.Default.Register<IDialogsViewModel, D.DialogsViewModel>();
                SimpleIoc.Default.Register<IPersonRequiredViewModel, D.PersonRequiredViewModel>();
                SimpleIoc.Default.Register<IPersonOptionalViewModel, D.PersonOptionalViewModel>();
                SimpleIoc.Default.Register<IPersonSummaryViewModel, D.PersonSummaryViewModel>();
                SimpleIoc.Default.Register<IPersonListViewModel, D.PersonListViewModel>();
                SimpleIoc.Default.Register<IPersonDetailsViewModel, D.PersonDetailsViewModel>();
                SimpleIoc.Default.Register<IMapViewModel, D.MapViewModel>();
            }

            SimpleIoc.Default.Register<GS.NavigationService>();
            SimpleIoc.Default.Register<INavigationService, NavigationService>();
            SimpleIoc.Default.Register<GS.IDialogService, GS.DialogService>();
            SimpleIoc.Default.Register<IWebService, WebService>();
            SimpleIoc.Default.Register<IFileService, FileService>();
            SimpleIoc.Default.Register<IApplicationSettingsService, ApplicationSettingsService>();
            SimpleIoc.Default.Register<ILauncherService, LauncherService>();
            SimpleIoc.Default.Register<IMapService, MapService>();
        }
    }
}
