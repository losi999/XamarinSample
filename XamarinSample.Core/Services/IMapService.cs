using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Model.Primitives;

namespace XamarinSample.Core.Services {
    public interface IMapService {
        Task<Coordinate> GetCurrentPositionAsync();
        Task LaunchGetDirectionsAsync(string title, Coordinate coordinate);
        Task LaunchMapsAsync(string title, Coordinate coordinate);
        Task LaunchMapsAsync(string address);
    }
}
