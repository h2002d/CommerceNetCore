using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommerceNetCore.Data;
using CommerceNetCore.Helpers;
using CommerceNetCore.Models;
using CommerceNetCore.Repositories.Categories;
using CommerceNetCore.Repositories.Products;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace CommerceNetCore.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        protected CommerceDbContext _commerceDbContext;
        private IHostingEnvironment _hostingEnvironment;

        public ProductController(ILogger<ProductController> logger, CommerceDbContext commerceDbContext, IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            _commerceDbContext = commerceDbContext;
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index(int id)
        {
            ProductRepository repository = new ProductRepository(_commerceDbContext);
            var product = repository.GetProduct(id);
            return View(product);
        }

        public IActionResult CategoryProducts()
        {
            return View();
        }

        public IActionResult Create()
        {
            CategoryRepository repository = new CategoryRepository(_commerceDbContext);
            ViewBag.Categories = new SelectList(repository.GetCategories(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product, [FromForm]List<IFormFile> formFiles)
        {
            ProductRepository repository = new ProductRepository(_commerceDbContext);
            try
            {
                var productNew = repository.Create(product);

                ProductImagesHelper helper = new ProductImagesHelper(_commerceDbContext, _hostingEnvironment);
                helper.SaveProductImage(formFiles, productNew.Id);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return RedirectToAction("Create");
        }

    }
}