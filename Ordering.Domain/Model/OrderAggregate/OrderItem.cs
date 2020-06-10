using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.Domain.OrderAggregate
{
    public class OrderItem
    {
        public int Id;
        public int amount;
        public int productCruid;
        public string productName;
        public int unitPrice;
        public int units;

        public OrderItem(int id)
        {
            this.Id = id;
        }

        public OrderItem()
        {
        }

        public int GetUnits()
        {
            throw new NotImplementedException();
        }

        public int SetUnits()
        {
            throw new NotImplementedException();
        }

        public int AddUnit()
        {
            throw new NotImplementedException();
        }
    }
}
