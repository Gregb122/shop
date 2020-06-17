using Ordering.Domain.BuyerAggregate;
using Ordering.Domain.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering.API
{
    public interface IOrderingService
    {
        public void AddOrder(Order order);
        public void AddBuyer(Buyer buyer);
        public void DeleteOrder(int Id);
        public void DeleteBuyer(int Id);
        public List<Order> GetAllOrders();
        public List<Buyer> GetAllBuyers();
    }
}
