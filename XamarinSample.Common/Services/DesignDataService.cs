using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Services;

namespace XamarinSample.Common.Services {
    public class DesignDataService : IDesignDataService {
        public T GetItemModel<T>() where T : class {
            return Activator.CreateInstance<T>();
        }

        public List<T> GetItemModels<T>(int count) where T : class, new() {
            var ret = new List<T>();
            if (count < 0) {
                count = 10;
            }

            for (int i = 1; i <= count; i++) {
                ret.Add((T)Activator.CreateInstance(typeof(T), i));
            }

            return ret;
        }

        public List<string> GetStrings(string prefix, int count) {
            var ret = new List<string>();

            for (int i = 1; i <= count; i++) {
                ret.Add(prefix + " #" + i);
            }

            return ret;
        }
    }

}
