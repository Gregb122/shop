using Ordering.Domain.BuyerAggregate.Repository;
using Ordering.Domain.OrderAggregate;
using Ordering.Domain.OrderAggregate.Repository;
using Ordering.Infrastructure.Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering.API
{
    public class OrderingService : IOrderingService
    {
        private IOrderRepository orderRepository;
        private IBuyerRepository buyerRepository;

        public OrderingService()
        {
            this.orderRepository = new OrderIM();
            this.buyerRepository = new BuyerIM();
        }

        public OrderingService(IOrderRepository orderRepository, IBuyerRepository buyerRepository)
        {
            this.orderRepository = orderRepository;
            this.buyerRepository = buyerRepository;
        }

        public void AddItemToDraftOrder()
        {
            throw new NotImplementedException();
        }

        public void AddOrder(Order order)
        {
            orderRepository.Add(order);
        }

        public void DeleteOrder(int id)
        {
            orderRepository.Delete(id);
        }

        public void GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public void GetOrderItemsList()
        {
            throw new NotImplementedException();
        }

        public void GetOrderStatus()
        {
            throw new NotImplementedException();
        }

        public void SetOrderAdress()
        {
            throw new NotImplementedException();
        }

        public void SubmitOrder()
        {
            throw new NotImplementedException();
        }
    }
}
