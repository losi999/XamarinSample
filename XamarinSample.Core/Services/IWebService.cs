using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Model.JsonModels;

namespace XamarinSample.Core.Services {
    public interface IWebService {
        Task<Rootobject> Get(string url);
    }
}
