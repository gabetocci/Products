using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Products.Entities;

namespace Products.Web.DataContexts
{
    public class ProductsDb : DbContext
    {
        public ProductsDb()
            : base("DefaultConnection")
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}