using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Data;
using XamarinSample.Core.Model.Primitives;

namespace XamarinSample.Windows10.Converters {
    public class CoordinateToGeopointConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            var coord = value as Coordinate;
            return new Geopoint(new BasicGeoposition() { Longitude = coord.Longitude, Latitude = coord.Latitude });
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }
}
