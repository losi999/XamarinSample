using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.ViewModel;
using GalaSoft.MvvmLight.Command;
using XamarinSample.Core.Services;

namespace XamarinSample.ViewModel {
    public class PersonsViewModel : ViewModelBase, IPersonsViewModel {
        private INavigationService _navigation;
        private IApplicationSettingsService _settings;

        public PersonsViewModel(INavigationService navigation, IApplicationSettingsService settings) {
            _navigation = navigation;
            _settings = settings;
        }

        public int PersonCount => _settings.Persons.Count;

        private RelayCommand _CommandNewPerson;
        public RelayCommand CommandNewPerson => _CommandNewPerson ??
            (_CommandNewPerson = new RelayCommand(() => {
                _navigation.NavigateToPersonRequiredPage();
            }));

        private RelayCommand _CommandListPersons;
        public RelayCommand CommandListPersons => _CommandListPersons ??
            (_CommandListPersons = new RelayCommand(() => {
                _navigation.NavigateToPersonListPage();
            }));

        private RelayCommand _CommandBackPressed;
        public RelayCommand CommandBackPressed => _CommandBackPressed ??
            (_CommandBackPressed = new RelayCommand(() => {
                _navigation.GoBack();
            }));
    }
}
