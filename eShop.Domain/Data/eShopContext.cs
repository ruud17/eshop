using System;
using eShop.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace eShop.Domain.Data
{
    public class eShopContext : DbContext
    {
        public eShopContext(DbContextOptions<eShopContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}

