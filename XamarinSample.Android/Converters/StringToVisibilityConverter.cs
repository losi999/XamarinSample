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

namespace XamarinSample.Android.Converters {
    public static class StringToVisibilityConverter {
        public static ViewStates Convert(string text) {
            return String.IsNullOrEmpty(text) ? ViewStates.Gone : ViewStates.Visible;
        }
    }
}