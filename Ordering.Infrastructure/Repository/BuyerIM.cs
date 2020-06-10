using Ordering.Domain.BuyerAggregate;
using Ordering.Domain.BuyerAggregate.Repository;
using Ordering.Domain.OrderAggregate;
using Ordering.Domain.OrderAggregate.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.Infrastructure.Repository
{
    public class BuyerIM : IBuyerRepository
    {
        private List<Buyer> Buyers = new List<Buyer>();

        public BuyerIM()
        {
            Buyers = new List<Buyer>
            {
                new Buyer { Id = 1, Name = "ktos1", Surname = "ktos1" },
                new Buyer { Id = 2, Name = "ktos2", Surname = "ktos2" },
                new Buyer { Id = 3, Name = "ktos3", Surname = "ktos3" },
                new Buyer { Id = 4, Name = "ktos4", Surname = "ktos4" },
            };
        }

        public void Add(Buyer Buyer)
        {
            Buyers.Add(Buyer);
        }

        public void Delete(int BuyerId)
        {
            foreach (var p in Buyers)
                if (p.Id == BuyerId)
                    Buyers.Remove(p);
        }

        public Buyer Find(int BuyerId)
        {
            foreach (var p in Buyers)
                if (p.Id == BuyerId)
                    return p;

            return null;
        }

        public void Update(Buyer Buyer)
        {
            foreach (var o in Buyers)
                if (o.Id == Buyer.Id)
                {
                    Buyers.Remove(o);
                    Buyers.Add(Buyer);
                }
        }
    }
}
