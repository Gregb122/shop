using Catalog.Domain.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Catalog.API
{
    interface ICatalogUtilities
    {
        public void AddProduct();
        public void DeleteProduct();
        public List<Product> getProductsCatalog();
    }
}
