using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.ViewModel;
using GalaSoft.MvvmLight.Command;
using XamarinSample.Core.Services;
using GS = GalaSoft.MvvmLight.Views;
using XamarinSample.Core.Model.JsonModels;

namespace XamarinSample.ViewModel {
    public class PersonSummaryViewModel : ViewModelBase, IPersonSummaryViewModel {
        private INavigationService _navigation;
        private IPersonRequiredViewModel _required;
        private IPersonOptionalViewModel _optional;
        private GS.IDialogService _dialog;
        private IApplicationSettingsService _settings;
        private IFileService _file;

        public PersonSummaryViewModel(INavigationService navigation, IPersonRequiredViewModel required, IPersonOptionalViewModel optional, GS.IDialogService dialog, IApplicationSettingsService settings, IFileService file) {
            _navigation = navigation;
            _required = required;
            _optional = optional;
            _dialog = dialog;
            _settings = settings;
            _file = file;
        }

        private RelayCommand _CommandBackPressed;
        public RelayCommand CommandBackPressed => _CommandBackPressed ??
            (_CommandBackPressed = new RelayCommand(() => {
                _navigation.GoBack();
            }));

        private RelayCommand _CommandSave;
        public RelayCommand CommandSave => _CommandSave ??
            (_CommandSave = new RelayCommand(async () => {
                if (Password != _required.Password) {
                    await _dialog.ShowMessage("Incorrect password!", "Error");
                    return;
                }
                var hasPhoto = !String.IsNullOrEmpty(PhotoPath);
                var person = new Person(_required.FirstName, _required.LastName, _required.Gender, _required.Age, Password, _optional.Address, _optional.EMail, _optional.PhoneNumber);

                if (hasPhoto) {
                    person.PhotoPath = PhotoPath;
                }
                _settings.StorePerson(person);

                _required.ClearProperties();
                _optional.ClearProperties();
                Password = "";
                _navigation.NavigateBackToPersonsPage();

            }));

        public string SummaryText =>
$@"Name: {_required.FirstName} {_required.LastName}
Gender: {_required.Gender.ToString()}
Age: {_required.Age}
E-mail: {_optional.EMail}
Address: {_optional.Address}
Phone: {_optional.PhoneNumber}";

        private string _Password;
        public string Password {
            get {
                return _Password;
            }
            set {
                if (_Password != value) {
                    _Password = value;
                    RaisePropertyChanged(nameof(Password));
                }
            }
        }

        public string PhotoPath => _optional.PhotoPath;
    }
}
