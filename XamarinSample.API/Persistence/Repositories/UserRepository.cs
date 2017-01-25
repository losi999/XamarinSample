using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamarinSample.API.Core.Model.Entities;
using XamarinSample.API.Core.Repositories;

namespace XamarinSample.API.Persistence.Repositories {
    public class UserRepository : RepositoryBase<User>, IUserRepository {
        public UserRepository(XamarinSampleDbContext context) : base(context) {
        }

        public User Get(string username, bool tracking = false) {
            var temp = IncludedSet.Where(x => x.Username == username);

            if (!tracking) {
                temp = temp.AsNoTracking();
            }

            return temp.FirstOrDefault();
        }
    }
}
