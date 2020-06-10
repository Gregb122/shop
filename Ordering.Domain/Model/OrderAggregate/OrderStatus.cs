using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ordering.Domain.OrderAggregate
{
    public enum OrderStatus
    {
        Draft,
        Submitted,
        StockConfirmed,
        Shipped,
        Cancelled
    }
}
