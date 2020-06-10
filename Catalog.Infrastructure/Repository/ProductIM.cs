using Catalog.Domain.ProductAggregate;
using Catalog.Domain.ProductAggregate.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Infrastructure.Repository
{
    class ProductIM : IProductRepository
    {
        private List<Product> products = new List<Product>();

        public ProductIM()
        {
            products = new List<Product>
            {
                new Product { Id = 1, productName = "cos", category = new ProductCategory() },
                new Product { Id = 2, productName = "cos", category = new ProductCategory() },
                new Product { Id = 3, productName = "cos", category = new ProductCategory() },
                new Product { Id = 4, productName = "cos", category = new ProductCategory() },
            };
        }

        public void Add(Product product)
        {
            products.Add(product);
        }

        public void delete(int productId)
        {
            foreach (var p in products)
                if (p.Id == productId)
                    products.Remove(p);
        }

        public Product Find(int productId)
        {
            foreach (var p in products)
                if (p.Id == productId)
                    return p;

            return null;
        }

        public List<Product> FindAll()
        {
            return products;
        }

        public void Update(Product product)
        {
            foreach (var p in products)
                if (p.Id == product.Id)
                {
                    products.Remove(p);
                    products.Add(product);
                }
        }
    }
}
