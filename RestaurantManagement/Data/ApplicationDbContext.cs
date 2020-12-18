using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using RestaurantManagement.Models;

namespace RestaurantManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       public DbSet<Product> products { get; set; }
      public  DbSet<Customer> customers { get; set; }

        public DbSet<Order> orders { get; set; }

    }
}
