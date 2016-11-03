using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public RelayCommand CommandDialog => new RelayCommand(new Action(() => {
            dialogService.ShowMessage("message", "title", "ok", "cancel", new Action<bool>((result) => {
                DialogResponse = result ? "Clicked ok" : "Clicked cancel";
            }));
        }));

        public RelayCommand CommandJson => new RelayCommand(new Action(async () => {
            var json = await webService.Get("http://szeged-ebed.rhcloud.com/?controller=api&action=index&day=2016-10-26");
            await fileService.Write("json.txt", JsonConvert.SerializeObject(json));
        }));
    }
}
