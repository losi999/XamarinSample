using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using XamarinSample.Core.Model.Enum;

namespace XamarinSample.Windows81.Converters {
    public class GenderToBooleanConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            return value.ToString() == parameter.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            return (bool)value ? Enum.Parse(typeof(Gender), parameter.ToString()) : Gender.Undefined;
        }
    }
}
