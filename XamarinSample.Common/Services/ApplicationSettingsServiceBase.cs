using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Model.JsonModels;
using XamarinSample.Core.Services;

namespace XamarinSample.Common.Services {
    public abstract class ApplicationSettingsServiceBase : IApplicationSettingsService {
        private const string SettingsValue1 = "settings_checkbox";
        private const string SettingsValue2 = "settings_switch";
        private const string SettingsValue3 = "settings_bar";
        private const string SettingsValue4 = "settings_selected_item";

        private const string PersonsList = "persons_list";

        protected abstract void Set<T>(string key, T value);
        protected abstract T Get<T>(string key, T defValue = default(T));

        public bool IsCheckBoxChecked {
            get {
                return Get(SettingsValue1, true);
            }

            set {
                Set(SettingsValue1, value);
            }
        }

        public bool IsSwitchChecked {
            get {
                return Get(SettingsValue2, true);
            }

            set {
                Set(SettingsValue2, value);
            }
        }

        public int BarValue {
            get {
                return Get(SettingsValue3, 1);
            }

            set {
                Set(SettingsValue3, value);
            }
        }

        public string SelectedItem {
            get {
                return Get(SettingsValue4, "");
            }

            set {
                Set(SettingsValue4, value);
            }
        }

        public List<Person> Persons {
            get {
                return Get(PersonsList, new List<Person>());
            }

            set {
                Set(PersonsList, value);
            }
        }

        public void StorePerson(Person person) {
            var temp = Persons;
            temp.Add(person);
            Persons = temp;
        }

        public Person GetPerson(string personId) {
            var temp = Persons;
            var item = temp.Where(p => p.Id == personId).First();
            return item;
        }

        public void DeletePerson(string personId) {
            var temp = Persons;
            var item = temp.Where(p => p.Id == personId).First();
            temp.Remove(item);
            Persons = temp;
        }
    }
}
