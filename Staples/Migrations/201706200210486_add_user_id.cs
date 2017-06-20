namespace Staples.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_user_id : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItemsModels", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.ItemsModels", "User_Id");
            AddForeignKey("dbo.ItemsModels", "User_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItemsModels", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.ItemsModels", new[] { "User_Id" });
            DropColumn("dbo.ItemsModels", "User_Id");
        }
    }
}
