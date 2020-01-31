using CommerceNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceNetCore.Repositories.Orders
{
    internal interface IOrderRepository
    {
        Order Create(Order order);
        void Delete(Order order);
        Order GetOrder(int Id);
        Order GetOrderByCustomerId(int customerId);
    }
}
