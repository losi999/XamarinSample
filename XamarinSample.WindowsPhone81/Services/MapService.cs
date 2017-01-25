using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.System;
using XamarinSample.Core.Model.Primitives;
using XamarinSample.Core.Services;

namespace XamarinSample.WindowsPhone81.Services {
    public class MapService : IMapService {
        public async Task<Coordinate> GetCurrentPositionAsync() {
            Geolocator geolocator = new Geolocator { DesiredAccuracyInMeters = 50, ReportInterval = 100, MovementThreshold = 100 };

            //checking if geolocator is allowed or not
            if (geolocator.LocationStatus != PositionStatus.Disabled) {
                var geoPosition = await geolocator.GetGeopositionAsync();
                return new Coordinate(geoPosition.Coordinate.Point.Position.Latitude, geoPosition.Coordinate.Point.Position.Longitude);
            }
            return null;
        }

        public async Task LaunchGetDirectionsAsync(string title, Coordinate coordinate) {
            var uri = new Uri($@"ms-walk-to:?destination.latitude={coordinate.Latitude.ToString(CultureInfo.InvariantCulture)}&destination.longitude={coordinate.Longitude.ToString(CultureInfo.InvariantCulture)}&destination.name={title}");

            var launcherOptions = new LauncherOptions();
            var success = await Launcher.LaunchUriAsync(uri, launcherOptions);
        }

        public async Task LaunchMapsAsync(string address) {
            var uri = new Uri($@"bingmaps:?where={address}&lvl=16");

            var launcherOptions = new LauncherOptions();
            var success = await Launcher.LaunchUriAsync(uri, launcherOptions);
        }

        public async Task LaunchMapsAsync(string title, Coordinate coordinate) {
            var uri = new Uri($@"bingmaps:?collection=point.{coordinate.Latitude.ToString(CultureInfo.InvariantCulture)}_{coordinate.Longitude.ToString(CultureInfo.InvariantCulture)}_{title}&lvl=16");

            var launcherOptions = new LauncherOptions();
            var success = await Launcher.LaunchUriAsync(uri, launcherOptions);
        }
    }
}
