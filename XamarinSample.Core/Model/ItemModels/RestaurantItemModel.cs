using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Model.JsonModels;

namespace XamarinSample.Core.Model.ItemModels {
    public class RestaurantItemModel {
        public RestaurantItemModel() {

        }

        public RestaurantItemModel(int id) {
            Id = id;
            Name = "Restaurant name " + id;
            Url = "http://" + id + ".hu";
        }

        public RestaurantItemModel(Restaurant r) {
            Id = r.id;
            Name = r.name;
            Url = r.url;
        }

        public int Id { get; }
        public string Name { get; }
        public string Url { get; }
    }
}
