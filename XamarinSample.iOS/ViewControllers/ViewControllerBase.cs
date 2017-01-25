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
        protected bool IsCreating { get; set; }

        public ViewControllerBase(IntPtr handle) : base(handle) {

        }

        public override void DidReceiveMemoryWarning() {
            base.DidReceiveMemoryWarning();
            foreach (var b in bindings) {
                b.Detach();
            }
            bindings.Clear();
        }

        public override void ViewDidLoad() {
            base.ViewDidLoad();
            IsCreating = true;
        }

        public override void ViewDidAppear(bool animated) {
            base.ViewDidAppear(animated);
            if (!IsCreating) {
                foreach (var b in bindings) {
                    b.ForceUpdateValueFromSourceToTarget();
                }
            }
            IsCreating = false;
        }
    }
}
