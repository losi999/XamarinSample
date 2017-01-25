using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinSample.iOS.Converters {
    public static class StringToInverseBooleanConverter {
        public static bool Convert(string text) {
            return string.IsNullOrEmpty(text);
        }
    }
}
