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
        public void DeleteOrder(int Id);
        public void GetOrderStatus();
        public void AddItemToDraftOrder();
        public void GetOrderItemsList();
        public void SetOrderAdress();
        public void SubmitOrder();
        public void GetAllProducts();
    }
}
