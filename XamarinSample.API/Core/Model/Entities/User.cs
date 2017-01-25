using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace XamarinSample.API.Core.Model.Entities {
    public class User : EntityBase {
        public User() {

        }

        public User(string username, string password) {
            Username = username;
            Password = password;
        }

        [NotMapped]
        public override int Id { get; set; }

        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
    }
}
