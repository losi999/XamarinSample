using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamarinSample.API.Core.Repositories;

namespace XamarinSample.API.Core {
    public interface IUnitOfWork {
        IUserRepository User { get; }

        bool Complete();
    }
}
