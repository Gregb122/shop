using Ordering.Domain.OrderAggregate;
using Ordering.Domain.OrderAggregate.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.Infrastructure.Repository
{
    public class OrderIM : IOrderRepository
    {
        private List<Order> orders = new List<Order>();

        public OrderIM()
        {
            orders = new List<Order>
            {
                new Order { Id = 101, address = new Address(), orderItems = new List<OrderItem>() },
                new Order { Id = 102, address = new Address(), orderItems = new List<OrderItem>() },
                new Order { Id = 103, address = new Address(), orderItems = new List<OrderItem>() },
                new Order { Id = 104, address = new Address(), orderItems = new List<OrderItem>() },
            };
        }

        public void Add(Order order)
        {
            orders.Add(order);
        }

        public void Delete(int orderId)
        {
            foreach (var p in orders)
                if (p.Id == orderId)
                    orders.Remove(p);
        }

        public Order Find(int orderId)
        {
            foreach (var p in orders)
                if (p.Id == orderId)
                    return p;

            return null;
        }

        public List<Order> FindAll()
        {
            return orders;
        }

        public void Update(Order order)
        {
            foreach (var o in orders)
                if (o.Id == order.Id)
                {
                    orders.Remove(o);
                    orders.Add(order);
                }
        }
    }
}
