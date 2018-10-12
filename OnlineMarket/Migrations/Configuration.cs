namespace OnlineMarket.Migrations
{
    using OnlineMarket.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OnlineMarket.Models.IdentityModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OnlineMarket.Models.IdentityModel context)
        {
            context.Products.AddOrUpdate(x => x.Guid,
               new Product()
               {
                   Guid = Guid.NewGuid(),
                   Name = "Redmi 6A (Black, 2GBRAM, 16GB Storage)",
                   Uri = "Products/Redmi6A",
                   Description = "Camera: 13 MP Rear camera | 5 MP front camera",
                   Price = 699000
               },
               new Product()
               {
                   Guid = Guid.NewGuid(),
                   Name = "Mi A2 (Black, 4GB RAM, 64GB Storage)",
                   Uri = "Products/MiA2",
                   Description = "Camera: 12+20 MP Dual rear camera | 20 MP front camera, Display: 15.21 centimetres (5.99-inch) Full HD+ capacitive touchscreen display with 2160x1080 pixels and 403 ppi pixel density | 2.5D Corning Gorilla Glass 5",
                   Price = 1235000
               },
               new Product()
               {
                   Guid = Guid.NewGuid(),
                   Name = "OnePlus 6 (Mirror Black, 8GB RAM, 128GB Storage)",
                   Uri = "Products/OnePlus6",
                   Description = "Camera: 20+16 MP Dual rear camera with Optical image stabilization, Super slow motion, Portrait mode | 16 MP front camera, ",
                   Price = 3490000
               },
               new Product()
               {
                   Guid = Guid.NewGuid(),
                   Name = "Lenovo K8 Note (Venom Black, 3GB RAM, 32GB Storage)",
                   Uri = "Products/LenovoK8Note",
                   Description = "Camera: 13+5 MP Dual rear camera | 13 MP front camera with party flash Display: 13.97 centimeters (5.5-inch) Full HD IPS touchscreen display with 1920x1080 pixels | Gorilla glass protection",
                   Price = 2490000
               },
               new Product()
               {
                   Guid = Guid.NewGuid(),
                   Name = "Motorola G5s Plus (Blush Gold, 4GB RAM, 64GB Storage)",
                   Uri = "Products/MotorolaG5sPlus",
                   Description = "Camera: 13+13 MP Dual rear camera with LED flash | 8 MP front camera with LED flash Display: 13.97 centimeters (5.5-inch) Full HD capacitive touchscreen display with 1080x1920 pixels | Gorilla Glass 3 protection",
                   Price = 4699000
               },
               new Product()
               {
                   Guid = Guid.NewGuid(),
                   Name = "Honor 7X (Blue, 4GB RAM, 32GB Storage)",
                   Uri = "Products/Honor7X",
                   Description = "Camera: 16+2 MP Dual rear camera | 8 MP front camera with Portrait mode Display: 15.06 centimeters (5.93-inch) Full HD+ capacitive touchscreen display with 1080x2160 pixels, 407 ppi pixel density and 18:9 aspect ratio",
                   Price = 5469000
               }
               );
        }
    }
}

