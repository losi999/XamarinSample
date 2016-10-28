using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSample.Core.Services {
    public interface INavigationService : GalaSoft.MvvmLight.Views.INavigationService {
        void NavigateToSecond(params object[] parameters);
    }
}
