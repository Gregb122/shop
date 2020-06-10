using Ordering.Domain.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.ObjectMothers
{
    public class OrderObjectMother
    {
        public static Order CreateOrder()
        {
            Order o = new Order { Id = 101, address = new Address(), orderItems = new List<OrderItem>() };
            return o;
        }

        public static OrderItem CreateSingleOrderItem()
        {
            OrderItem o = new OrderItem { Id = 10 };
            return o;
        }
    }
}
