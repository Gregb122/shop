using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.Domain.BuyerAggregate
{
    public class Buyer
    {
        public int Id;
        public string Name;
        public string Surname;
        public DateTime BirthDate;

        public Buyer()
        {
        }

        public void SetBirthDate()
        {
            throw new NotImplementedException();
        }
    }
}
