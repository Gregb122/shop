using Ordering.Domain.BuyerAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.ObjectMothers
{
    public class BuyerObjectMother
    {
        public static Buyer CreateBuyer()
        {
            Buyer b = new Buyer { Id = 10, Name = "ktos1", Surname = "ktos1" };
            return b;
        }
    }
}
