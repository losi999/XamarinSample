using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using XamarinSample.Core.Services;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.DesignViewModel {
    public class SettingsViewModel : ISettingsViewModel {
        private IDesignDataService _data;

        public SettingsViewModel(IDesignDataService data) {
            _data = data;

            BarValue = 7;
            IsCheckBoxChecked = true;
            IsSwitchChecked = false;
            SelectedItemIndex = 3;
            Items = new ObservableCollection<string>(_data.GetStrings("design ", 10));
            SelectedItem = Items[SelectedItemIndex];
        }

        public int BarValue { get; set; }
        public RelayCommand CommandBackPressed { get; }
        public bool IsCheckBoxChecked { get; set; }
        public bool IsSwitchChecked { get; set; }
        public ObservableCollection<string> Items { get; }
        public string SelectedItem { get; set; }
        public int SelectedItemIndex { get; set; }
    }
}
