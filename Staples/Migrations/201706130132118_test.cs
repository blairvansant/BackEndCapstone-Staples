namespace Staples.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItemsModels", "Perishable", c => c.String());
            AddColumn("dbo.ItemsModels", "NonPerishable", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ItemsModels", "NonPerishable");
            DropColumn("dbo.ItemsModels", "Perishable");
        }
    }
}
