using System.Data.Entity;

namespace OnlineMarket.Models
{
    public interface IIdentityModel
    {
        DbSet<Cart> Carts { get; set; }
        DbSet<Product> Products { get; set; }
    }
}