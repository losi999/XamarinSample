using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Model.JsonModels;
using XamarinSample.Core.Services;

namespace XamarinSample.Common.Services {
    public class WebService : IWebService {
        public async Task<string> LogIn(string username, string password) {
            HttpClient client = new HttpClient();
            var postData = new List<KeyValuePair<string, string>>();
            postData.Add(new KeyValuePair<string, string>("username", username));
            postData.Add(new KeyValuePair<string, string>("password", password));

            var response = await client.PostAsync(new Uri("http://xamarinsampleapi.azurewebsites.net/api/mobile/login"), new FormUrlEncodedContent(postData));
            if (response.IsSuccessStatusCode) {
                return "";
            }
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }

        public async Task<bool> SignUp(string username, string password) {
            HttpClient client = new HttpClient();
            var postData = new List<KeyValuePair<string, string>>();
            postData.Add(new KeyValuePair<string, string>("username", username));
            postData.Add(new KeyValuePair<string, string>("password", password));

            var response = await client.PostAsync(new Uri("http://xamarinsampleapi.azurewebsites.net/api/mobile/signup"), new FormUrlEncodedContent(postData));
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return true;
            }
            return false;
        }
    }
}
