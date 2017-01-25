using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml.Data;

namespace XamarinSample.Windows10.Converters {
    public class AnchorPointConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            var temp = (int)value;

            int vertical = temp / 10;
            int horizontal = temp % 10;

            double x = 0;
            double y = 0;

            switch (horizontal) {
                case 1: x = 0; break;
                case 2: x = 0.5; break;
                case 3: x = 1; break;
            }

            switch (vertical) {
                case 1: y = 0; break;
                case 2: y = 0.5; break;
                case 3: y = 1; break;
            }

            return new Point(x, y);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }
}
