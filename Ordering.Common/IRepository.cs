using System;

namespace Ordering.Common
{
    public interface IRepository<T>
    {
        public void Add(T obj);

        public void Update(T obj);

        public void Delete(int objId);

        public T Find(int objId);
    }
}
