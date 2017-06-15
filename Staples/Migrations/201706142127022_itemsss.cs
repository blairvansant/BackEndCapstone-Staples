namespace Staples.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class itemsss : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ItemsModels", "TimeToPurchase");
            DropColumn("dbo.ItemsModels", "Perishable");
            DropColumn("dbo.ItemsModels", "NonPerishable");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ItemsModels", "NonPerishable", c => c.String());
            AddColumn("dbo.ItemsModels", "Perishable", c => c.String());
            AddColumn("dbo.ItemsModels", "TimeToPurchase", c => c.String());
        }
    }
}
