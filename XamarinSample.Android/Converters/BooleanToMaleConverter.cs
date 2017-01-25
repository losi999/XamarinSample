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
using XamarinSample.Core.Model.Enum;

namespace XamarinSample.Android.Converters {
    public static class BooleanToMaleConverter {
        public static Gender Convert(bool isMale) {
            return isMale ? Gender.Male : Gender.Female;
        }

        public static bool ConvertBack(Gender gender) {
            return gender == Gender.Male;
        }
    }
}