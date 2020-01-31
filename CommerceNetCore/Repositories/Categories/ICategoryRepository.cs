using CommerceNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommerceNetCore.Repositories.Categories
{
    interface ICategoryRepository
    {
        Category Create(string Name,
           string Description
           );

        Category Update(Category category);

        void Delete(Category category);

        Category GetCategoryById(int Id);

        List<Category> GetCategories();
    }
}
