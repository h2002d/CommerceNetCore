using CommerceNetCore.Data;
using CommerceNetCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceNetCore.Repositories.Orders
{
    public class OrderRepository : IOrderRepository
    {
        protected CommerceDbContext _commerceDbContext;
        public OrderRepository(CommerceDbContext commerceDbContext)
        {
            _commerceDbContext = commerceDbContext;
        }
        public Order Create(Order order)
        {
            _commerceDbContext.Order.Add(order);
            _commerceDbContext.SaveChanges();
            return order;
        }

        public void Delete(Order order)
        {
            _commerceDbContext.Order.Remove(order);
            _commerceDbContext.SaveChanges();
        }

        public Order GetOrder(int Id)
        {
            var order = _commerceDbContext.Order.Where(o => o.Id == Id).Include(c => c.Customer).Include(c => c.Products).ThenInclude(p => p.ProductImages).FirstOrDefault();
            return order;
        }

        public Order GetOrderByCustomerId(int customerId)
        {
            var order = _commerceDbContext.Order.Where(o => o.CustomerId == customerId).Include(c => c.Customer).Include(c => c.Products).ThenInclude(p => p.ProductImages).FirstOrDefault();
            return order;
        }
    }
}
