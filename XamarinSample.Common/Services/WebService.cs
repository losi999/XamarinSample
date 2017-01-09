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
        public async Task<Rootobject> Get(string url) {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(new Uri(url));
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                var json = JsonConvert.DeserializeObject<Rootobject>(content);
                return json;
            }
            return null;
        }
    }
}
