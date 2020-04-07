using System;
using System.Collections.Generic;
using FoodieFavorites.Core;
using Microsoft.EntityFrameworkCore;

namespace FoodieFavorites.Data
{
    public class FoodieFavsDbContext : DbContext
    {
        public FoodieFavsDbContext(DbContextOptions<FoodieFavsDbContext> options) :
            base(options)
        {
            
        }
        
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}