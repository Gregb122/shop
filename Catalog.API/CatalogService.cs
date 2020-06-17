using Catalog.Domain.ProductAggregate;
using Catalog.Domain.ProductAggregate.Repository;
using Catalog.Infrastructure.Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API
{
    public class CatalogService : ICatalogService
    {
        private IProductRepository productRepository;

        public CatalogService()
        {
            this.productRepository = new ProductIM();
        }

        public CatalogService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public void AddProduct(Product product)
        {
            productRepository.Add(product);
        }

        public void DeleteProduct(int Id)
        {
            productRepository.Delete(Id);
        }

        public List<Product> GetAllProducts()
        {
            return productRepository.FindAll();
        }
    }
}
