using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommerceNetCore.Models;

namespace CommerceNetCore.Repositories.Customers
{
    interface ICustomerRepository
    {
        Customer Create(string Name,
         string Description
         );

        Customer Update(Customer category);

        //Dont think we need such functionality
        //void Delete(Category category);
    }
}
