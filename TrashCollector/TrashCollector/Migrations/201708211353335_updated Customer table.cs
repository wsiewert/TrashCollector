namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedCustomertable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DaysOfWeek_Id", c => c.Int());
            CreateIndex("dbo.Customers", "DaysOfWeek_Id");
            AddForeignKey("dbo.Customers", "DaysOfWeek_Id", "dbo.DaysOfWeeks", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "DaysOfWeek_Id", "dbo.DaysOfWeeks");
            DropIndex("dbo.Customers", new[] { "DaysOfWeek_Id" });
            DropColumn("dbo.Customers", "DaysOfWeek_Id");
        }
    }
}
