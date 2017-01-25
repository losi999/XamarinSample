using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using A = Android.Net;
using Android.Views;
using Android.Widget;
using XamarinSample.Core.Model.Primitives;
using XamarinSample.Core.Services;
using Android.Locations;
using System.Globalization;

namespace XamarinSample.Android.Services {
    public class MapService : IMapService {

        private class LocationListener : Java.Lang.Object, ILocationListener {
            public void OnLocationChanged(Location location) {
                System.Diagnostics.Debug.WriteLine(location.Latitude + " " + location.Longitude);
                LocationChanged?.Invoke(this, new Coordinate(location.Latitude, location.Longitude));
            }

            public void OnProviderDisabled(string provider) {

            }

            public void OnProviderEnabled(string provider) {

            }

            public void OnStatusChanged(string provider, [GeneratedEnum] Availability status, Bundle extras) {

            }

            public delegate void CoordinateHandler(object sender, Coordinate coordinate);
            public event CoordinateHandler LocationChanged;
        }


        public Task<Coordinate> GetCurrentPositionAsync() {
            TaskCompletionSource<Coordinate> ret = new TaskCompletionSource<Coordinate>();

            LocationListener listener = new LocationListener();

            LocationManager locationManager;
            string Provider = LocationManager.GpsProvider;

            locationManager = Application.Context.GetSystemService(Context.LocationService) as LocationManager;

            if (!string.IsNullOrEmpty(Provider) && locationManager.IsProviderEnabled(Provider)) {
                listener.LocationChanged += (s, c) => {
                    ret.SetResult(c);
                };
                locationManager.RequestLocationUpdates(Provider, 2000, 1, listener);
            }

            return ret.Task;
        }

        public Task LaunchGetDirectionsAsync(string title, Coordinate coordinate) {
            var geoUri = A.Uri.Parse($"google.navigation:q={coordinate.Latitude.ToString(CultureInfo.InvariantCulture)},{coordinate.Longitude.ToString(CultureInfo.InvariantCulture)}");
            var mapIntent = new Intent(Intent.ActionView, geoUri);

            App.CurrentActivity.StartActivity(mapIntent);

            return Task.CompletedTask;
        }

        public Task LaunchMapsAsync(string title, Coordinate coordinate) {
            var geoUri = A.Uri.Parse($"geo:0,0?q={coordinate.Latitude.ToString(CultureInfo.InvariantCulture)},{coordinate.Longitude.ToString(CultureInfo.InvariantCulture)}({title})");
            var mapIntent = new Intent(Intent.ActionView, geoUri);

            App.CurrentActivity.StartActivity(mapIntent);

            return Task.CompletedTask;
        }

        public Task LaunchMapsAsync(string address) {
            var geoUri = A.Uri.Parse($"geo:0,0?q={address}");
            var mapIntent = new Intent(Intent.ActionView, geoUri);

            App.CurrentActivity.StartActivity(mapIntent);

            return Task.CompletedTask;
        }
    }
}