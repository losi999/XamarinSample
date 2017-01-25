using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.DesignViewModel {
    public class MainViewModel : IMainViewModel {
        public MainViewModel() {
        }

        public RelayCommand CommandBackPressed { get; }
        public RelayCommand CommandDialogsPage { get; }
        public RelayCommand CommandLoginPage { get; }
        public RelayCommand CommandMapPage { get; }
        public RelayCommand CommandPersonsPage { get; }
        public RelayCommand CommandSettingsPage { get; }
    }
}
