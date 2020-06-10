using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Ordering.Domain.OrderAggregate
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime orderStartDate;
        public DateTime? orderEndDate;
        public Address address;
        public int buyerId;

        public OrderStatus orderStatus;

        public List<OrderItem> orderItems;

        public Order(int id, Address address, List<OrderItem> orderItems)
        {
            this.Id = id;
            this.address = address;
            this.orderItems = orderItems;
        }

        public Order(int id, DateTime orderStartDate, DateTime? orderEndDate, Address address, int buyerId, OrderStatus orderStatus, List<OrderItem> orderItems)
        {
            this.Id = id;
            this.orderStartDate = orderStartDate;
            this.orderEndDate = orderEndDate;
            this.address = address;
            this.buyerId = buyerId;
            this.orderStatus = orderStatus;
            this.orderItems = orderItems;
        }

        public Order()
        {
        }

        public void AddOrderItem()
        {
            throw new NotImplementedException();
        }

        public OrderStatus GetOrderStatus()
        {
            throw new NotImplementedException();
        }

        public void setOrderStatus()
        {
            throw new NotImplementedException();
        }

        public void setAdress()
        {
            throw new NotImplementedException();
        }

        public Address GetAddress()
        {
            throw new NotImplementedException();
        }
    }
}