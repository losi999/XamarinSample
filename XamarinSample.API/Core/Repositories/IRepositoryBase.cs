using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamarinSample.API.Core.Model.Entities;

namespace XamarinSample.API.Core.Repositories {
    public interface IRepositoryBase<T> where T : EntityBase {
        IEnumerable<T> Get(bool tracking = false);
        T Get(int id, bool tracking = false);
        void Delete(int id);
        void Insert(T obj);
        void Insert(IEnumerable<T> obj);
        void Update(T obj);
    }
}
