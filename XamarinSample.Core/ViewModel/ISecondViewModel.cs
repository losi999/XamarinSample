using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Command;
using XamarinSample.Core.Model.ItemModels;

namespace XamarinSample.Core.ViewModel {
    public interface ISecondViewModel : IViewModelBase {
        RelayCommand CommandDialog { get; }
        RelayCommand CommandJson { get; }
        string DialogResponse { get; set; }
        ObservableCollection<RestaurantItemModel> Restaurants { get; }
    }
}