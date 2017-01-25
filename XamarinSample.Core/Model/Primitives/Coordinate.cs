using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSample.Core.Model.Primitives {
    public class Coordinate {
        public Coordinate(double latitude, double longitude) {
            Longitude = longitude;
            Latitude = latitude;
        }

        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public override string ToString() {
            return Latitude + " " + Longitude;
        }
    }
}
