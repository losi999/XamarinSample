using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using XamarinSample.Core.Model.ItemModels;
using XamarinSample.Core.Services;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.DesignViewModel {
    public class PersonListViewModel : IPersonListViewModel {
        private IDesignDataService _data;

        public PersonListViewModel(IDesignDataService data) {
            _data = data;

            Persons = new ObservableCollection<PersonItemModel>(_data.GetItemModels<PersonItemModel>(15));
        }

        public RelayCommand CommandBackPressed { get; }
        public RelayCommand CommandLoaded { get; }

        public ObservableCollection<PersonItemModel> Persons { get; }
    }
}
