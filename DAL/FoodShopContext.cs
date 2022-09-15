using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.DAL
{
    public class FoodShopContext:DbContext
    {
        public FoodShopContext(DbContextOptions<FoodShopContext> options) : base(options)
        {

        }
    }
}
