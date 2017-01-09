using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSample.Core.Services {
    public interface IDesignDataService {
        List<T> GetItemModels<T>(int count) where T : class, new();
        List<string> GetStrings(string prefix, int count);
        T GetItemModel<T>() where T : class;
    }
}
