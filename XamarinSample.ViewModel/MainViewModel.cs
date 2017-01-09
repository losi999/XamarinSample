using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Services;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.ViewModel {
    public class MainViewModel : ViewModelBase, IMainViewModel {

        private readonly INavigationService _navigationService;

        public MainViewModel(INavigationService navigationService) {
            _navigationService = navigationService;
        }


        private RelayCommand _CommandClick;
        public RelayCommand CommandClick => _CommandClick ??
            (_CommandClick = new RelayCommand(() => {
                Count++;
            }));

        private RelayCommand _CommandSecondPage;
        public RelayCommand CommandSecondPage => _CommandSecondPage ??
            (_CommandSecondPage = new RelayCommand(() => {
                _navigationService.NavigateToSecond();
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
