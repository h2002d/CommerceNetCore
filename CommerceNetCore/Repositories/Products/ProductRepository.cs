using CommerceNetCore.Data;
using CommerceNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceNetCore.Repositories.Products
{
    public class ProductRepository : IProductRepository
    {
        protected CommerceDbContext _commerceDbContext;
        public ProductRepository(CommerceDbContext commerceDbContext)
        {
            _commerceDbContext = commerceDbContext;
        }
        public Product Create(Product product)
        {
            product.CreateDate = DateTime.Now;
            if (product.Id == 0)
            {
                _commerceDbContext.Product.Add(product);
                _commerceDbContext.SaveChanges();
            }
            else
            {
                _commerceDbContext.Product.Update(product);
                _commerceDbContext.SaveChanges();
            }
            return product;
        }

        public void Delete(Product product)
        {
            _commerceDbContext.Product.Remove(product);
            _commerceDbContext.SaveChanges();
        }

        public Product GetProduct(int Id)
        {
            var product = _commerceDbContext.Product.Find(Id);
            _commerceDbContext.Entry(product).Reference(p => p.Category).Load();
            _commerceDbContext.Entry(product).Collection(p => p.ProductImages).Load();
            return product;
        }
    }
}
