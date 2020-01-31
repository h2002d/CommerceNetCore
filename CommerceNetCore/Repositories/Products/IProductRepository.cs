using CommerceNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceNetCore.Repositories.Products
{
    internal interface IProductRepository
    {
        Product Create(Product product);
        void Delete(Product product);
        Product GetProduct(int Id);
    }
}
