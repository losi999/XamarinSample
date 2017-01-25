using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using XamarinSample.Core.Model.ItemModels;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.DesignViewModel {
    public class MapViewModel : IMapViewModel {
        public MapViewModel() {
            IsAreaButtonEnabled = true;
        }

        public RelayCommand CommandBackPressed { get; }
        public RelayCommand CommandGetCurrentPosition { get; }
        public RelayCommand CommandGetPointsInArea { get; }
        public RelayCommand CommandOpenMapsApp { get; }
        public RelayCommand CommandGetDirections { get; }
        public RelayCommand CommandLoaded { get; }


        public ObservableCollection<MapItemModel> CurrentCoordinate { get; }
        public ObservableCollection<MapItemModel> AreaCoordinates { get; }

        public bool IsAreaButtonEnabled { get; }

    }
}
