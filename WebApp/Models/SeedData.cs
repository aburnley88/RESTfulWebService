using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();
            if(context.Products.Count() == 0 && context.Suppliers.Count() == 0
                && context.Categories.Count() == 0)
            {
                Supplier s1 = new Supplier
                {Name= "Splash Dudes", City= "San Jose" };
            }
        }
    }
}
