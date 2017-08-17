namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedaspnetusersforeignkey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "CustomerId", c => c.Int(nullable: false));
            CreateIndex("dbo.AspNetUsers", "CustomerId");
            AddForeignKey("dbo.AspNetUsers", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
            DropColumn("dbo.AspNetUsers", "Value");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Value", c => c.Int(nullable: false));
            DropForeignKey("dbo.AspNetUsers", "CustomerId", "dbo.Customers");
            DropIndex("dbo.AspNetUsers", new[] { "CustomerId" });
            DropColumn("dbo.AspNetUsers", "CustomerId");
        }
    }
}
