using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineMarket.Models
{
    public class IdentityModel : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }

        public IdentityModel() : base("name=DefaultConnection")
        {

        }
    }
}