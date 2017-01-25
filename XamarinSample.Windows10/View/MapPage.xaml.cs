using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using XamarinSample.Core.Model.ItemModels;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.Windows10.View {
    public sealed partial class MapPage : Page {
        public MapPage() {
            this.InitializeComponent();

            (DataContext as IMapViewModel).CurrentCoordinate.CollectionChanged += CurrentCoordinate_CollectionChanged;
        }

        private async void CurrentCoordinate_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e) {
            if (e.Action != System.Collections.Specialized.NotifyCollectionChangedAction.Reset) {
                var coord = (sender as ObservableCollection<MapItemModel>).FirstOrDefault();
                if (coord != null) {
                    var geoposition = new BasicGeoposition { Latitude = coord.Coordinate.Latitude, Longitude = coord.Coordinate.Longitude };

                    await map.TrySetViewAsync(new Geopoint(geoposition), 15, null, null, MapAnimationKind.Bow);
                }
            }
        }
    }
}
