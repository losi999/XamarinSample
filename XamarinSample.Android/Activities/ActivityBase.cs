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
using GalaSoft.MvvmLight;
using XamarinSample.ViewModel;
using GalaSoft.MvvmLight.Views;
using GalaSoft.MvvmLight.Helpers;
using XamarinSample.Core.ViewModel;
using GS = GalaSoft.MvvmLight.Views;

namespace XamarinSample.Android.Activities {

    public abstract class ActivityBase : GS.ActivityBase {

        protected List<Binding> bindings = new List<Binding>();

        public delegate void ActivityResultHandler(object sender, Result result);
        public event ActivityResultHandler ActivityResult;

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            ActivityResult?.Invoke(this, resultCode);
            ActivityResult = null;
        }

        protected override void OnDestroy()
        {
            foreach (var b in bindings)
            {
                b.Detach();
            }
            base.OnDestroy();

        }

        protected override void OnResume() {

            base.OnResume();

            App.CurrentActivity = this;

        }

        protected override void OnStop() {
            base.OnStop();
            App.BackStack.Push(this);
        }

    }

    public abstract class ActivityBase<T> : ActivityBase where T : IViewModelBase {

        protected abstract T ViewModel { get; }
        protected bool IsCreating { get; set; }

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);
            IsCreating = true;
        }

        protected override void OnResume() {

            base.OnResume();

            
            if (!IsCreating) {
                foreach (var b in bindings) {
                    b.ForceUpdateValueFromSourceToTarget();
                }
            }
            IsCreating = false;
        }

    }
}