using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSample.Core.ViewModel {
    public interface ISettingsViewModel : IViewModelBase {
        bool IsCheckBoxChecked { get; set; }
        bool IsSwitchChecked { get; set; }
        int BarValue { get; set; }
        ObservableCollection<string> Items { get; }
        int SelectedItemIndex { get; set; }
        string SelectedItem { get; }
    }
}
