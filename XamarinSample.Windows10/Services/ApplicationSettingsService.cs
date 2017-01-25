using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using XamarinSample.Common.Services;

namespace XamarinSample.Windows10.Services {
    public class ApplicationSettingsService : ApplicationSettingsServiceBase {
        private ApplicationDataContainer storage;

        public ApplicationSettingsService() {
            storage = ApplicationData.Current.LocalSettings;
        }

        protected override void Set<T>(string key, T value) {
            if (!storage.Values.ContainsKey(key)) {
                storage.Values.Add(key, JsonConvert.SerializeObject(value));
            }
            else {
                storage.Values[key] = JsonConvert.SerializeObject(value);
            }
        }

        protected override T Get<T>(string key, T defValue = default(T)) {
            if (storage.Values.ContainsKey(key)) {
                return JsonConvert.DeserializeObject<T>(storage.Values[key].ToString());
            }

            return defValue;
        }
    }
}
