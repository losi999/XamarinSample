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
    public static class BooleanToFemaleConverter {
        public static Gender Convert(bool isFemale) {
            return isFemale ? Gender.Female : Gender.Male;
        }

        public static bool ConvertBack(Gender gender) {
            return gender == Gender.Female;
        }
    }
}