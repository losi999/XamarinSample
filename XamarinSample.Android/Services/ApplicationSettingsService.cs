using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinSample.Common.Services;
using Android.Preferences;
using Newtonsoft.Json;

namespace XamarinSample.Android.Services {
    public class ApplicationSettingsService : ApplicationSettingsServiceBase {
        private ISharedPreferences prefs;
        private ISharedPreferencesEditor editor;

        public ApplicationSettingsService() {
            prefs = PreferenceManager.GetDefaultSharedPreferences(Application.Context);
            editor = prefs.Edit();
        }

        protected override T Get<T>(string key, T defValue = default(T)) {
            return JsonConvert.DeserializeObject<T>(prefs.GetString(key, JsonConvert.SerializeObject(defValue)));
        }

        protected override void Set<T>(string key, T value) {
            editor.PutString(key, JsonConvert.SerializeObject(value));
            editor.Apply();
        }
    }
}