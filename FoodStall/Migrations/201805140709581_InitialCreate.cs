namespace FoodStall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(),
                        UnitNumber = c.String(),
                        Address = c.String(),
                        PostalCode = c.Int(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Food",
                c => new
                    {
                        FoodID = c.Int(nullable: false),
                        FoodName = c.String(nullable: false, maxLength: 50),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        Food_Photo = c.Binary(),
                    })
                .PrimaryKey(t => t.FoodID);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        CustomerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customer", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.OrderDetail",
                c => new
                    {
                        OrderDetailID = c.Int(nullable: false),
                        Size = c.Int(nullable: false),
                        Chilli = c.Boolean(nullable: false),
                        MoreSalt = c.Boolean(nullable: false),
                        Pepper = c.Boolean(nullable: false),
                        Quantity = c.Int(nullable: false),
                        FoodID = c.Int(nullable: false),
                        OrderID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderDetailID)
                .ForeignKey("dbo.Food", t => t.FoodID, cascadeDelete: true)
                .ForeignKey("dbo.Order", t => t.OrderID, cascadeDelete: true)
                .Index(t => t.FoodID)
                .Index(t => t.OrderID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetail", "OrderID", "dbo.Order");
            DropForeignKey("dbo.OrderDetail", "FoodID", "dbo.Food");
            DropForeignKey("dbo.Order", "CustomerID", "dbo.Customer");
            DropIndex("dbo.OrderDetail", new[] { "OrderID" });
            DropIndex("dbo.OrderDetail", new[] { "FoodID" });
            DropIndex("dbo.Order", new[] { "CustomerID" });
            DropTable("dbo.OrderDetail");
            DropTable("dbo.Order");
            DropTable("dbo.Food");
            DropTable("dbo.Customer");
        }
    }
}
