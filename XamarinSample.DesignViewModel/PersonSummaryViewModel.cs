using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.DesignViewModel {
    public class PersonSummaryViewModel : IPersonSummaryViewModel {

        public PersonSummaryViewModel() {
            Password = "password";
            SummaryText = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type sp";
        }
        public RelayCommand CommandBackPressed { get; }
        public RelayCommand CommandSave { get; }

        public string Password { get; set; }

        public string PhotoPath { get; }
        public string SummaryText { get; }
    }
}
