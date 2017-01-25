using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using XamarinSample.Core.ViewModel;

namespace XamarinSample.DesignViewModel {
    public class PersonsViewModel : IPersonsViewModel {
        public PersonsViewModel() {
            PersonCount = 10;
        }

        public RelayCommand CommandBackPressed { get; }
        public RelayCommand CommandListPersons { get; }
        public RelayCommand CommandNewPerson { get; }
        public int PersonCount { get; }
    }
}
