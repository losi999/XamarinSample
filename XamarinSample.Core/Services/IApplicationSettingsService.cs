using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Model.JsonModels;

namespace XamarinSample.Core.Services {
    public interface IApplicationSettingsService {
        bool IsCheckBoxChecked { get; set; }
        bool IsSwitchChecked { get; set; }
        int BarValue { get; set; }
        string SelectedItem { get; set; }

        void StorePerson(Person person);
        List<Person> Persons { get; set; }
        Person GetPerson(string personId);
        void DeletePerson(string personId);
    }
}
