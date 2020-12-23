using FirstDotnet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstDotnet.Data
{
    public  class RestaurantDbContext:DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options)
            :base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
