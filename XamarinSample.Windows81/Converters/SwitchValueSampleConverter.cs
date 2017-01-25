using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace XamarinSample.Windows81.Converters {
    public class SwitchValueSampleConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            return (bool)value ? "Switch on" : "Switch off";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }
}
