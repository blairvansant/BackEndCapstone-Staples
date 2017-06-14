namespace Staples.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Items : DbMigration
    {
        public override void Up()
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ItemModels");
        }
    }
}
