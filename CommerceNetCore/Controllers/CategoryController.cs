using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommerceNetCore.Data;
using CommerceNetCore.Repositories.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CommerceNetCore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;
        protected CommerceDbContext _commerceDbContext;
        protected CategoryRepository repository;
        public CategoryController(ILogger<CategoryController> logger, CommerceDbContext commerceDbContext)
        {
            _logger = logger;
            _commerceDbContext = commerceDbContext;
            repository = new CategoryRepository(_commerceDbContext);
        }

        public IActionResult Index(int id)
        {
            var category = repository.GetCategoryById(id);

            return View(category);
        }

        public IActionResult _LayoutPartial()
        {
            
            var categories = repository.GetCategories();
            return PartialView(categories);
        }
    }
}