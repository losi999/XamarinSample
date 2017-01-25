using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.ViewModel;
using GalaSoft.MvvmLight.Command;
using XamarinSample.Core.Services;
using System.Collections.ObjectModel;
using XamarinSample.Core.Model.ItemModels;

namespace XamarinSample.ViewModel {
    public class PersonListViewModel : ViewModelBase, IPersonListViewModel {
        private IApplicationSettingsService _settings;
        private INavigationService _navigation;
        private ILauncherService _launcher;
        private IPersonDetailsViewModel _personDetails;

        public PersonListViewModel(IApplicationSettingsService settings, INavigationService navigation, ILauncherService launcher, IPersonDetailsViewModel personDetails) {
            _navigation = navigation;
            _settings = settings;
            _launcher = launcher;
            _personDetails = personDetails;

            Persons = new ObservableCollection<PersonItemModel>();
        }


        private RelayCommand _CommandBackPressed;
        public RelayCommand CommandBackPressed => _CommandBackPressed ??
            (_CommandBackPressed = new RelayCommand(() => {
                _navigation.GoBack();
            }));

        private RelayCommand _CommandLoaded;
        public RelayCommand CommandLoaded => _CommandLoaded ??
            (_CommandLoaded = new RelayCommand(() => {
                Persons.Clear();

                foreach (var p in _settings.Persons) {
                    Persons.Add(new PersonItemModel(p, PersonDetails));
                }
            }));

        private void PersonDetails(string personId) {
            _personDetails.PersonId = personId;
            _navigation.NavigateToPersonDetailsPage();
        }

        public ObservableCollection<PersonItemModel> Persons { get; }
    }
}
