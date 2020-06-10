using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.ProductAggregate.Repository
{
    public interface IProductRepository
    {
        public void Add(Product product);

        public void delete(int productId);

        public Product Find(int productId);

        public void Update(Product product);

        public List<Product> FindAll();
    }
}
