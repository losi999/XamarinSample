using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamarinSample.API.Core;
using XamarinSample.API.Core.Repositories;
using XamarinSample.API.Persistence.Repositories;

namespace XamarinSample.API.Persistence {
    public class UnitOfWork : IUnitOfWork {
        private XamarinSampleDbContext _context { get; }

        public IUserRepository User { get; }

        public UnitOfWork(XamarinSampleDbContext c) {
            _context = c;

            User = new UserRepository(_context);
        }

        public bool Complete() => _context.SaveChanges() > 0;
    }
}
