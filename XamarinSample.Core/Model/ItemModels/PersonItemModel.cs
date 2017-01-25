using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Model.JsonModels;

namespace XamarinSample.Core.Model.ItemModels {
    public class PersonItemModel {

        public PersonItemModel() {

        }

        public PersonItemModel(int id) {
            Name = $"name{id} last{id}";
            Age = id;
            Gender = id % 2 == 0 ? Enum.Gender.Male : Enum.Gender.Female;

            if (id % 2 == 1) {
                Address = $"address{id}";
            }

            if (id % 2 == 0) {
                EMail = $"email{id}";
            }

            PhoneNumber = "+12345678";
        }

        public PersonItemModel(Person p, Action<string> personDetailsAction) {
            Id = p.Id;
            Name = $"{p.FirstName} {p.LastName}";
            Age = p.Age;
            Gender = p.Gender;
            Address = p.Address;
            EMail = p.EMail;
            PhoneNumber = p.PhoneNumber;
            CommandPersonDetails = new RelayCommand<string>(personDetailsAction);
        }

        public override string ToString() {
            string ret =
$@"Name: {Name}
Age: {Age}
Gender: {Gender}
Address: {Address}
E-mail: {EMail}
Phone: {PhoneNumber}";

            return ret;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Enum.Gender Gender { get; set; }
        public string Address { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public RelayCommand<string> CommandPersonDetails { get; }
    }
}
