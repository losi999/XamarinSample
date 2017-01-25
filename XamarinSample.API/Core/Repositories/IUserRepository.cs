using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamarinSample.API.Core.Model.Entities;

namespace XamarinSample.API.Core.Repositories {
    public interface IUserRepository : IRepositoryBase<User> {
        User Get(string username, bool tracking = false);
    }
}
