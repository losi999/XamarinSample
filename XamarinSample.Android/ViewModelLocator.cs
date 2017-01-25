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
using GalaSoft.MvvmLight.Ioc;
using XamarinSample.Core.Services;
using XamarinSample.Android.Services;
using GS = GalaSoft.MvvmLight.Views;
using XamarinSample.Common.Services;
using XamarinSample.ViewModel;

namespace XamarinSample.Android {
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