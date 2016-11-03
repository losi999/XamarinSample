using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Services;

namespace XamarinSample.BackEnd.ViewModel {
    public class MainViewModel : ViewModelBase {

        private readonly INavigationService navigationService;

        public MainViewModel() {

        }

        [PreferredConstructor]
        public MainViewModel(INavigationService navigationService) {
            this.navigationService = navigationService;
        }


        public RelayCommand CommandClick => new RelayCommand(new Action(() => {
            Count++;
        }));


        public RelayCommand CommandSecondPage => new RelayCommand(new Action(() => {
            navigationService.NavigateToSecond();
        }));

        private int _Count;

        public int Count {
            get {
                return _Count;
            }
            set {
                if (_Count != value) {
                    _Count = value;
                    RaisePropertyChanged(nameof(Count));
                }
            }
        }
    }
}
