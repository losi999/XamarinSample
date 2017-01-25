using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Model.Enum;

namespace XamarinSample.Core.Model.JsonModels {
    public class Person {
        public Person() {

        }

        public Person(string firstName, string lastName, Gender gender, int age, string password, string address, string email, string phone) {
            Id = Guid.NewGuid().ToString();
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Age = age;
            Password = password;
            Address = address;
            EMail = email;
            PhoneNumber = phone;
        }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public string PhotoPath { get; set; }
    }
}
