using CommerceNetCore.Data;
using CommerceNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceNetCore.Repositories.ProductImages
{
    public class ProductImageRepository : IProductImageRepository
    {
        protected CommerceDbContext _commerceDbContext;
        public ProductImageRepository(CommerceDbContext commerceDbContext)
        {
            _commerceDbContext = commerceDbContext;
        }
        public ProductImage Create(ProductImage productImage)
        {
            _commerceDbContext.ProductImage.Add(productImage);
            _commerceDbContext.SaveChanges();
            return productImage;
        }

        public void Delete(ProductImage productImage)
        {
            _commerceDbContext.ProductImage.Remove(productImage);
            _commerceDbContext.SaveChanges();
        }

        public ProductImage GetProductImage(int Id)
        {
            var product = _commerceDbContext.ProductImage.Find(Id);
            return product;
        }
    }
}
