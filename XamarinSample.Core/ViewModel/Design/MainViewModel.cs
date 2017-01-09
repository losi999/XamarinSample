using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;

namespace XamarinSample.Core.ViewModel.Design {
    public class MainViewModel : ViewModelBase, IMainViewModel {
        public MainViewModel() {
            Count = 5;
        }

        public RelayCommand CommandClick { get; }
        public RelayCommand CommandSecondPage { get; }

        public int Count { get; set; }
    }
}
