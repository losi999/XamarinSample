using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSample.Core.Model.JsonModels {

    public class Rootobject {
        public Menu[] menu { get; set; }
        public Restaurant[] restaurants { get; set; }
        public string dayOfWeek { get; set; }
        public DateTime nextDay { get; set; }
        public DateTime prevDay { get; set; }
        public DateTime today { get; set; }
        public DateTime setDay { get; set; }
    }

    public class Menu {
        public int id { get; set; }
        public DateTime date { get; set; }
        public string soup { get; set; }
        public string menuA { get; set; }
        public string menuB { get; set; }
        public string menuC { get; set; }
        public string menuD { get; set; }
        public DateTime lastUpdated { get; set; }
        public int restaurantId { get; set; }
        public string restaurantName { get; set; }
    }

    public class Restaurant {
        public int id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public float? lat { get; set; }
        public float? lng { get; set; }
    }

}
