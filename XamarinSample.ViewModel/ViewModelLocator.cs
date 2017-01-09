using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Services;
using XamarinSample.Core.ViewModel;
using XamarinSample.Common.Services;
using D = XamarinSample.Core.ViewModel.Design;

namespace XamarinSample.ViewModel {
    public class ViewModelLocator {

        public ViewModelLocator() {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            if (ViewModelBase.IsInDesignModeStatic) {
                SimpleIoc.Default.Register<IDesignDataService, DesignDataService>();

                SimpleIoc.Default.Register<IMainViewModel, D.MainViewModel>();
                SimpleIoc.Default.Register<ISecondViewModel, D.SecondViewModel>();
            }
            else {
                SimpleIoc.Default.Register<IMainViewModel, MainViewModel>();
                SimpleIoc.Default.Register<ISecondViewModel, SecondViewModel>();
            }

        }


        public IMainViewModel Main => ServiceLocator.Current.GetInstance<IMainViewModel>();
        public ISecondViewModel Second => ServiceLocator.Current.GetInstance<ISecondViewModel>();
    }
}
