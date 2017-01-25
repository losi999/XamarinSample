using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;
using XamarinSample.Common.Services;
using XamarinSample.Core.Services;
using XamarinSample.iOS.Services;
using XamarinSample.ViewModel;
using GS = GalaSoft.MvvmLight.Views;

namespace XamarinSample.iOS {
    public class ViewModelLocator : ViewModelLocatorBase {
        public ViewModelLocator() {
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
