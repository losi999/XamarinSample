using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using XamarinSample.API.Core.Model.Entities;

namespace XamarinSample.API.Persistence {
    public class XamarinSampleDbContext : DbContext {
        public XamarinSampleDbContext(DbContextOptions<XamarinSampleDbContext> options) : base(options) {

        }

        public DbSet<User> Users { get; set; }
    }
}
