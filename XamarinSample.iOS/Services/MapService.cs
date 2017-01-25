using CoreLocation;
using Foundation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using XamarinSample.Core.Model.Primitives;
using XamarinSample.Core.Services;

namespace XamarinSample.iOS.Services {
    public class MapService : IMapService {

        public Task<Coordinate> GetCurrentPositionAsync() {
            TaskCompletionSource<Coordinate> task = new TaskCompletionSource<Coordinate>();

            var LocationManager = new CLLocationManager();

            if (LocationManager.RespondsToSelector(new ObjCRuntime.Selector("requestWhenInUseAuthorization")))
                LocationManager.RequestWhenInUseAuthorization();

            LocationManager.DesiredAccuracy = CLLocation.AccuracyBest;
            LocationManager.DistanceFilter = CLLocationDistance.FilterNone;
            LocationManager.LocationsUpdated += (s, e) => {
                System.Diagnostics.Debug.WriteLine("updated");
                if (e.Locations.Length > 0) {
                    if (!task.Task.IsCompleted) {
                        task.SetResult(new Coordinate(e.Locations[0].Coordinate.Latitude, e.Locations[0].Coordinate.Longitude));
                    }
                }
                LocationManager.StopUpdatingLocation();

            };
            LocationManager.StartUpdatingLocation();
            return task.Task;
        }

        public async Task LaunchGetDirectionsAsync(string title, Coordinate coordinate) {
            string url = $"http://maps.apple.com/?daddr={coordinate.Latitude.ToString(CultureInfo.InvariantCulture)},{coordinate.Longitude.ToString(CultureInfo.InvariantCulture)}&q={title}";
            url = url.Replace(" ", "%20");
            if (UIApplication.SharedApplication.CanOpenUrl(new NSUrl(url))) {
                UIApplication.SharedApplication.OpenUrl(new NSUrl(url));
            }
            else {
                new UIAlertView("Error", "Maps is not supported on this device", null, "Ok").Show();
            }
        }

        public async Task LaunchMapsAsync(string address) {
            string url = $"http://maps.apple.com/?q={address}";
            url = url.Replace(" ", "%20");
            if (UIApplication.SharedApplication.CanOpenUrl(new NSUrl(url))) {
                UIApplication.SharedApplication.OpenUrl(new NSUrl(url));
            }
            else {
                new UIAlertView("Error", "Maps is not supported on this device", null, "Ok").Show();
            }


        }

        public async Task LaunchMapsAsync(string title, Coordinate coordinate) {
            string url = $"http://maps.apple.com/?ll={coordinate.Latitude.ToString(CultureInfo.InvariantCulture)},{coordinate.Longitude.ToString(CultureInfo.InvariantCulture)}&q={title}";
            url = url.Replace(" ", "%20");
            if (UIApplication.SharedApplication.CanOpenUrl(new NSUrl(url))) {
                UIApplication.SharedApplication.OpenUrl(new NSUrl(url));
            }
            else {
                new UIAlertView("Error", "Maps is not supported on this device", null, "Ok").Show();
            }
        }
    }
}
