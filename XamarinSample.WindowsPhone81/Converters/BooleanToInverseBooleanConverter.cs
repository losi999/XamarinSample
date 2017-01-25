using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace XamarinSample.WindowsPhone81.Converters {
    public class BooleanToInverseBooleanConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            return !(bool)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            return !(bool)value;
        }
    }
}
