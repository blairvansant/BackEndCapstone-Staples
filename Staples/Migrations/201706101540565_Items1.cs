namespace Staples.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Items1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemsModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameOfItem = c.String(),
                        DateOfPurchase = c.String(),
                        ExpirationDate = c.String(),
                        TimeToPurchase = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.ItemModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ItemModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        DateOfPurchase = c.String(),
                        ExpirationDate = c.String(),
                        TimeToPurchase = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            DropTable("dbo.ItemsModels");
        }
    }
}
