using Ordering.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.Domain.BuyerAggregate.Repository
{
    public interface IBuyerRepository : IRepository<Buyer>
    {
        public new void Add(Buyer order);

        public new void Delete(int orderId);

        public new Buyer Find(int orderId);

        public new void Update(Buyer order);
    }
}
