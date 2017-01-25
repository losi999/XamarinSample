using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Model.ItemModels;

namespace XamarinSample.Core.ViewModel {
    public interface IMapViewModel : IViewModelBase {
        RelayCommand CommandGetCurrentPosition { get; }
        RelayCommand CommandGetPointsInArea { get; }
        RelayCommand CommandOpenMapsApp { get; }
        RelayCommand CommandGetDirections { get; }
        RelayCommand CommandLoaded { get; }

        ObservableCollection<MapItemModel> CurrentCoordinate { get; }
        ObservableCollection<MapItemModel> AreaCoordinates { get; }
        bool IsAreaButtonEnabled { get; }
    }
}
