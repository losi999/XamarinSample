using Foundation;
using GalaSoft.MvvmLight.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.iOS.ViewControllers {
    public abstract class ViewControllerBase<T> : UIViewController where T : IViewModelBase {
        protected abstract T ViewModel { get; }
        protected List<Binding> bindings = new List<Binding>();

        public ViewControllerBase(IntPtr handle) : base(handle) {

        }
    }
}
