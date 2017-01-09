using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Model.ItemModels;
using XamarinSample.Core.Model.JsonModels;
using XamarinSample.Core.Services;
using XamarinSample.Core.ViewModel;
using GS = GalaSoft.MvvmLight.Views;

namespace XamarinSample.ViewModel {
    public class SecondViewModel : ViewModelBase, ISecondViewModel {
        private readonly INavigationService _navigationService;
        private readonly GS.IDialogService _dialogService;
        private readonly IWebService _webService;
        private readonly IFileService _fileService;

        public SecondViewModel(
            INavigationService navigationService,
            GS.IDialogService dialogService,
            IWebService webService,
            IFileService fileService) {

            _navigationService = navigationService;
            _dialogService = dialogService;
            _webService = webService;
            _fileService = fileService;

            Restaurants = new ObservableCollection<RestaurantItemModel>();
        }


        private string _DialogResponse;
        public string DialogResponse {
            get {
                return _DialogResponse;
            }
            set {
                if (_DialogResponse != value) {
                    _DialogResponse = value;
                    RaisePropertyChanged(nameof(DialogResponse));
                }
            }
        }


        public ObservableCollection<RestaurantItemModel> Restaurants { get; }

        public RelayCommand CommandDialog => new RelayCommand(new Action(() => {
            _dialogService.ShowMessage("message", "title", "ok", "cancel", new Action<bool>((result) => {
                DialogResponse = result ? "Clicked ok" : "Clicked cancel";
            }));
        }));

        public RelayCommand CommandJson => new RelayCommand(new Action(async () => {
            var json = await _webService.Get("http://szeged-ebed.rhcloud.com/?controller=api&action=index&day=" + DateTime.Today.ToString("yyyy-MM-dd"));

            Restaurants.Clear();
            foreach (var r in json?.restaurants) {
                Restaurants.Add(new RestaurantItemModel(r));
            }
            _fileService.Write("json.txt", JsonConvert.SerializeObject(json));
        }));
    }
}
