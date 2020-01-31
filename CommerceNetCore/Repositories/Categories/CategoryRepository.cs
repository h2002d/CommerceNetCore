using CommerceNetCore.Data;
using CommerceNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CommerceNetCore.Repositories.Categories
{
    public class CategoryRepository : ICategoryRepository
    {
        protected CommerceDbContext _commerceDbContext;
        public CategoryRepository(CommerceDbContext commerceDbContext)
        {
            _commerceDbContext = commerceDbContext;
        }
        public Category Create(string Name, string Description)
        {
            Category category = new Category() { Name = Name, Description = Description };
            _commerceDbContext.Category.Add(category);
            _commerceDbContext.SaveChanges();
            return category;
        }

        public void Delete(Category category)
        {
            _commerceDbContext.Category.Remove(category);
            _commerceDbContext.SaveChanges();
        }

        public Category GetCategoryById(int Id)
        {
            var category = _commerceDbContext.Category.Where(c => c.Id == Id).Include(c => c.Products).ThenInclude(p => p.ProductImages).FirstOrDefault();
            return category;
        }


        public List<Category> GetCategories()
        {
            List<Category> category = new List<Category>();
            category = _commerceDbContext.Category.ToList();
            return category;
        }

        public Category Update(Category category)
        {
            _commerceDbContext.Category.Add(category);
            _commerceDbContext.SaveChanges();
            return category;
        }
    }
}
