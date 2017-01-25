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
using XamarinSample.Android.Activities;

namespace XamarinSample.Android {
    public static class App {
        private static ViewModelLocator locator;

        public static ViewModelLocator Locator {
            get {
                if (locator == null) {
                    DispatcherHelper.Initialize();
                    locator = new ViewModelLocator();
                }

                return locator;
            }
        }

        public static ActivityBase CurrentActivity { get; set; }

        private static Stack<ActivityBase> backStack;
        public static Stack<ActivityBase> BackStack => backStack ?? (backStack = new Stack<ActivityBase>());


    }
}