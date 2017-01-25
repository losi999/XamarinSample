using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.ViewModel;
using GalaSoft.MvvmLight.Command;
using XamarinSample.Core.Services;
using System.Collections.ObjectModel;
using XamarinSample.Core.Model.ItemModels;
using XamarinSample.Core.Model.Primitives;

namespace XamarinSample.ViewModel {
    public class MapViewModel : ViewModelBase, IMapViewModel {
        private IMapService _map;

        public MapViewModel(IMapService map) {
            _map = map;

            CurrentCoordinate = new ObservableCollection<MapItemModel>();
            AreaCoordinates = new ObservableCollection<MapItemModel>();
        }

        private RelayCommand _CommandGetCurrentPosition;
        public RelayCommand CommandGetCurrentPosition => _CommandGetCurrentPosition ??
            (_CommandGetCurrentPosition = new RelayCommand(async () => {
                var coordinate = await _map.GetCurrentPositionAsync();
                CurrentCoordinate.Clear();

                CurrentPosition = coordinate;
                CurrentCoordinate.Add(new MapItemModel(CurrentPosition));
            }));

        private RelayCommand _CommandBackPressed;
        public RelayCommand CommandBackPressed => _CommandBackPressed ??
            (_CommandBackPressed = new RelayCommand(() => {

            }));

        private RelayCommand _CommandLoaded;
        public RelayCommand CommandLoaded => _CommandLoaded ??
            (_CommandLoaded = new RelayCommand(() => {
                CurrentCoordinate.Clear();
            }));


        private RelayCommand _CommandGetPointsInArea;
        public RelayCommand CommandGetPointsInArea => _CommandGetPointsInArea ??
            (_CommandGetPointsInArea = new RelayCommand(() => {
                AreaCoordinates.Clear();

                Random rand = new Random();
                for (int i = 1; i <= 4; i++) {
                    var longitude = rand.Next(20) - 10;
                    var latitude = rand.Next(20) - 10;
                    AreaCoordinates.Add(new MapItemModel(new Coordinate(CurrentPosition.Latitude + ((latitude * 0.0005)), CurrentPosition.Longitude + ((longitude * 0.0005)))));
                }
            }));

        private RelayCommand _CommandGetDirections;
        public RelayCommand CommandGetDirections => _CommandGetDirections ??
            (_CommandGetDirections = new RelayCommand(async () => {
                await _map.LaunchGetDirectionsAsync("destination", new Coordinate(CurrentPosition.Latitude + 0.01, CurrentPosition.Longitude));
            }));

        private RelayCommand _CommandOpenMapsApp;
        public RelayCommand CommandOpenMapsApp => _CommandOpenMapsApp ??
            (_CommandOpenMapsApp = new RelayCommand(async () => {
                await _map.LaunchMapsAsync("destination", CurrentPosition);
            }));

        private Coordinate _CurrentPosition;
        private Coordinate CurrentPosition {
            get {
                return _CurrentPosition;
            }
            set {
                _CurrentPosition = value;
                RaisePropertyChanged(nameof(IsAreaButtonEnabled));
            }
        }

        public bool IsAreaButtonEnabled => CurrentPosition != null;
        public ObservableCollection<MapItemModel> CurrentCoordinate { get; }
        public ObservableCollection<MapItemModel> AreaCoordinates { get; }

    }
}
