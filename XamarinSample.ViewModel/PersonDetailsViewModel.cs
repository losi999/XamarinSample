using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using XamarinSample.Core.ViewModel;
using GalaSoft.MvvmLight;
using XamarinSample.Core.Model.Enum;
using XamarinSample.Core.Model.ItemModels;
using XamarinSample.Core.Services;
using XamarinSample.Core.Model.JsonModels;
using GS = GalaSoft.MvvmLight.Views;

namespace XamarinSample.ViewModel {
    public class PersonDetailsViewModel : ViewModelBase, IPersonDetailsViewModel {
        private ILauncherService _launcher;
        private IMapService _map;
        private IApplicationSettingsService _settings;
        private GS.IDialogService _dialog;
        private INavigationService _navigation;
        private IFileService _file;

        public PersonDetailsViewModel(ILauncherService launcher, IMapService map, IApplicationSettingsService settings, GS.IDialogService dialog, INavigationService navigation, IFileService file) {
            _launcher = launcher;
            _map = map;
            _settings = settings;
            _dialog = dialog;
            _navigation = navigation;
            _file = file;
        }

        private RelayCommand _CommandBackPressed;
        public RelayCommand CommandBackPressed => _CommandBackPressed ??
            (_CommandBackPressed = new RelayCommand(() => {

            }));

        private RelayCommand _CommandDial;
        public RelayCommand CommandDial => _CommandDial ??
            (_CommandDial = new RelayCommand(() => {
                _launcher.DialPhoneNumber(Name, PhoneNumber);
            }));

        private RelayCommand _CommandSendEMail;
        public RelayCommand CommandSendEMail => _CommandSendEMail ??
            (_CommandSendEMail = new RelayCommand(() => {
                _launcher.SendEmail(EMail);
            }));

        private RelayCommand _CommandShowOnMap;
        public RelayCommand CommandShowOnMap => _CommandShowOnMap ??
            (_CommandShowOnMap = new RelayCommand(() => {
                _map.LaunchMapsAsync(Address);
            }));

        private RelayCommand _CommandDeletePerson;
        public RelayCommand CommandDeletePerson => _CommandDeletePerson ??
            (_CommandDeletePerson = new RelayCommand(async () => {
                await _dialog.ShowMessage("Are you sure?", "Delete", "Yes", "No", (isConfirm) => {
                    if (isConfirm) {
                        _settings.DeletePerson(PersonId);
                        _file.Delete(PhotoPath);
                        _navigation.GoBack();
                    }
                });
            }));

        public string Name => _Person.FirstName + " " + _Person.LastName;
        public int Age => _Person.Age;
        public string Address => _Person.Address;
        public string PhoneNumber => _Person.PhoneNumber;
        public string EMail => _Person.EMail;
        public Gender Gender => _Person.Gender;
        public string PhotoPath => _Person.PhotoPath;

        private Person _Person;
        private string _PersonId;
        public string PersonId {
            get {
                return _PersonId;
            }
            set {
                if (_PersonId != value) {
                    _PersonId = value;
                    _Person = _settings.GetPerson(_PersonId);

                    RaisePropertyChanged(nameof(Name));
                    RaisePropertyChanged(nameof(Age));
                    RaisePropertyChanged(nameof(Address));
                    RaisePropertyChanged(nameof(Gender));
                    RaisePropertyChanged(nameof(EMail));
                    RaisePropertyChanged(nameof(PhoneNumber));
                }
            }
        }

    }
}
