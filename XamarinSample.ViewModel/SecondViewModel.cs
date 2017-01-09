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

namespace XamarinSample.BackEnd.ViewModel {
    public class SecondViewModel : ViewModelBase {
        private readonly INavigationService navigationService;
        private readonly GalaSoft.MvvmLight.Views.IDialogService dialogService;
        private readonly IWebService webService;
        private readonly IFileService fileService;

        public SecondViewModel(
            INavigationService navigationService,
            GalaSoft.MvvmLight.Views.IDialogService dialogService,
            IWebService webService,
            IFileService fileService) {

            this.navigationService = navigationService;
            this.dialogService = dialogService;
            this.webService = webService;
            this.fileService = fileService;
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


        private ObservableCollection<RestaurantItemModel> _Restaurants;
        public ObservableCollection<RestaurantItemModel> Restaurants {
            get {
                return _Restaurants ?? (_Restaurants = new ObservableCollection<RestaurantItemModel>());
            }
            set {
                if (_Restaurants != value) {
                    _Restaurants = value;
                    RaisePropertyChanged(nameof(Restaurants));
                }
            }
        }

        public RelayCommand CommandDialog => new RelayCommand(new Action(() => {
            dialogService.ShowMessage("message", "title", "ok", "cancel", new Action<bool>((result) => {
                DialogResponse = result ? "Clicked ok" : "Clicked cancel";
            }));
        }));

        public RelayCommand CommandJson => new RelayCommand(new Action(async () => {
            var json = await webService.Get("http://szeged-ebed.rhcloud.com/?controller=api&action=index&day=" + DateTime.Today.ToString("yyyy-MM-dd"));

            Restaurants.Clear();
            foreach (var r in json?.restaurants) {
                Restaurants.Add(new RestaurantItemModel(r));
            }
            fileService.Write("json.txt", JsonConvert.SerializeObject(json));
        }));
    }
}
