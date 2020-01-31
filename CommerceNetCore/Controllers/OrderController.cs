using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommerceNetCore.Data;
using CommerceNetCore.Models;
using CommerceNetCore.Repositories.Orders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CommerceNetCore.Controllers
{
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;
        protected CommerceDbContext _commerceDbContext;
        protected OrderRepository _orderRepository;
        public OrderController(ILogger<OrderController> logger, CommerceDbContext commerceDbContext)
        {
            _logger = logger;
            _commerceDbContext = commerceDbContext;
            _orderRepository = new OrderRepository(_commerceDbContext);
        }


        public IActionResult Create(int Id)
        {
            return View(Id);
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            _orderRepository.Create(order);
            return RedirectToAction("Create",order.Id);
        }
    }
}