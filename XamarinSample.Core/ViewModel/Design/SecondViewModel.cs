using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using XamarinSample.Core.Model.ItemModels;
using XamarinSample.Core.Services;

namespace XamarinSample.Core.ViewModel.Design {
    public class SecondViewModel : ViewModelBase, ISecondViewModel {
        private IDesignDataService _data;

        public SecondViewModel(IDesignDataService data) {
            _data = data;

            DialogResponse = "design dialog response";
        }

        public RelayCommand CommandDialog { get; }
        public RelayCommand CommandJson { get; }

        public string DialogResponse { get; set; }

        public ObservableCollection<RestaurantItemModel> Restaurants => new ObservableCollection<RestaurantItemModel>(_data.GetItemModels<RestaurantItemModel>(10));
    }
}
