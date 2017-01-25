using Foundation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using XamarinSample.Common.Services;

namespace XamarinSample.iOS.Services {
    public class ApplicationSettingsService : ApplicationSettingsServiceBase {
        private NSUserDefaults preferences;

        public ApplicationSettingsService() {
            preferences = NSUserDefaults.StandardUserDefaults;
        }

        protected override T Get<T>(string key, T defValue = default(T)) {
            var temp = preferences.StringForKey(key);
            if (String.IsNullOrEmpty(temp)) {
                return defValue;
            }
            return JsonConvert.DeserializeObject<T>(temp);
        }

        protected override void Set<T>(string key, T value) {
            preferences.SetString(JsonConvert.SerializeObject(value), key);
        }
    }
}
