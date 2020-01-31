using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommerceNetCore.Models;
namespace CommerceNetCore.Repositories.ProductImages
{
    internal interface IProductImageRepository
    {
        ProductImage Create(ProductImage product);
        void Delete(ProductImage product);
        ProductImage GetProductImage(int Id);
    }
}
