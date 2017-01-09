using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Threading;
using UIKit;
using XamarinSample.Common.Services;
using XamarinSample.Core.Services;
using XamarinSample.iOS.Services;
using XamarinSample.ViewModel;
using GS = GalaSoft.MvvmLight.Views;

namespace XamarinSample.iOS {
    public class Application {
        private static ViewModelLocator locator;
        public static ViewModelLocator Locator {
            get {
                if (locator == null) {
                    //DispatcherHelper.Initialize();

                    SimpleIoc.Default.Register<GS.IDialogService, GS.DialogService>();
                    SimpleIoc.Default.Register<IWebService>(() => new WebService());
                    SimpleIoc.Default.Register<IFileService>(() => new FileService());

                    locator = new ViewModelLocator();
                }

                return locator;
            }
        }

        // This is the main entry point of the application.
        static void Main(string[] args) {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}