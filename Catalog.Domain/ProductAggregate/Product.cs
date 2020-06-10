using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.ProductAggregate
{
    public class Product
    {
        public int Id;
        public string serialNumber;
        public string productName;
        public ProductCategory category;

        public Product()
        {
        }
    }
}
