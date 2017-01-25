using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSample.Core.ViewModel {
    public interface IPersonsViewModel : IViewModelBase {
        int PersonCount { get; }
        RelayCommand CommandNewPerson { get; }
        RelayCommand CommandListPersons { get; }
    }
}
