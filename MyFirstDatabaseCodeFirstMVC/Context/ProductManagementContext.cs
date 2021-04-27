using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MyFirstDatabaseCodeFirstMVC.Models;

namespace MyFirstDatabaseCodeFirstMVC.Context
{
    public class ProductManagementContext:DbContext
    {
        public ProductManagementContext() : base("ProductManagementContextDB") { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}