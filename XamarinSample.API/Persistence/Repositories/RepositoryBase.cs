using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamarinSample.API.Core.Model.Entities;
using XamarinSample.API.Core.Repositories;

namespace XamarinSample.API.Persistence.Repositories {
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase, new() {
        protected XamarinSampleDbContext _context;
        private DbSet<T> Set { get; }
        protected virtual IQueryable<T> IncludedSet => Set.AsQueryable();


        public RepositoryBase(XamarinSampleDbContext context) {
            _context = context;
            Set = _context.Set<T>();
        }

        public virtual IEnumerable<T> Get(bool tracking = false) {
            var temp = IncludedSet;

            if (!tracking) {
                temp = temp.AsNoTracking();
            }

            return temp.ToList();
        }

        public virtual T Get(int id, bool tracking = false) {
            var temp = IncludedSet.Where(x => x.Id == id);

            if (!tracking) {
                temp = temp.AsNoTracking();
            }

            return temp.First();
        }

        public virtual void Insert(IEnumerable<T> obj) {
            Set.AddRange(obj);
        }


        public virtual void Insert(T obj) =>
            Set.Add(obj);

        public virtual void Update(T obj) {
            _context.Entry(obj).State = EntityState.Modified;
        }

        public virtual void Delete(int id) =>
            _context.Entry(new T() { Id = id }).State = EntityState.Deleted;

    }
}
