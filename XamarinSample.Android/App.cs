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
using GalaSoft.MvvmLight.Threading;
using GalaSoft.MvvmLight.Ioc;
using XamarinSample.Android.Activities;
using XamarinSample.Core.Services;
using XamarinSample.Android.Services;
using XamarinSample.Common.Services;
using XamarinSample.ViewModel;

namespace XamarinSample.Android {
    public static class App {
        private static ViewModelLocator locator;

        public static ViewModelLocator Locator {
            get {
                if (locator == null) {
                    DispatcherHelper.Initialize();

                    SimpleIoc.Default.Register<INavigationService>(() => new NavigationService());
                    SimpleIoc.Default.Register<GalaSoft.MvvmLight.Views.IDialogService>(() => new GalaSoft.MvvmLight.Views.DialogService());
                    SimpleIoc.Default.Register<IWebService>(() => new WebService());
                    SimpleIoc.Default.Register<IFileService>(() => new FileService());

                    locator = new ViewModelLocator();
                }

                return locator;
            }
        }
    }
}