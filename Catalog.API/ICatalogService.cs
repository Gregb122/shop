using Catalog.Domain.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Catalog.API
{
    interface ICatalogService
    {
        public void AddProduct(Product product);
        public void DeleteProduct(int Id);
        public List<Product> GetAllProducts();
    }
}
