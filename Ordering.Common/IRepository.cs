using System;
using System.Collections.Generic;

namespace Ordering.Common
{
    public interface IRepository<T>
    {
        public void Add(T obj);

        public void Update(T obj);

        public void Delete(int objId);

        public T Find(int objId);

        public List<T> FindAll();
    }
}
