namespace OnlineMarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Guid = c.Guid(nullable: false),
                        ProductId = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        Amount = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Guid);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Guid = c.Guid(nullable: false),
                        Name = c.String(),
                        Uri = c.String(),
                        Description = c.String(),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Guid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.Carts");
        }
    }
}
