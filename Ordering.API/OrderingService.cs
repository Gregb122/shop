using Ordering.Domain.BuyerAggregate;
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

        public void AddOrder(Order order)
        {
            orderRepository.Add(order);
        }

        public void AddBuyer(Buyer buyer)
        {
            buyerRepository.Add(buyer);
        }

        public void DeleteOrder(int id)
        {
            orderRepository.Delete(id);
        }

        public void DeleteBuyer(int id)
        {
            buyerRepository.Delete(id);
        }

        public List<Order> GetAllOrders()
        {
            return orderRepository.FindAll();
        }

        public List<Buyer> GetAllBuyers()
        {
            return buyerRepository.FindAll();
        }
    }
}
