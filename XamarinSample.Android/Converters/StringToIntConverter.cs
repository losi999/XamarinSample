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
    public static class StringToIntConverter {
        public static int Convert(string text) {
            int ret = 0;
            int.TryParse(text, out ret);
            return ret;
        }
    }
}