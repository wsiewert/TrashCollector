namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixeddayofweekid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "DayOfWeek_Id", "dbo.DaysOfWeeks");
            DropIndex("dbo.Customers", new[] { "DayOfWeek_Id" });
            RenameColumn(table: "dbo.Customers", name: "DayOfWeek_Id", newName: "DayOfWeekId");
            AlterColumn("dbo.Customers", "DayOfWeekId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "DayOfWeekId");
            AddForeignKey("dbo.Customers", "DayOfWeekId", "dbo.DaysOfWeeks", "Id", cascadeDelete: true);
            DropColumn("dbo.Customers", "PickupDay");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "PickupDay", c => c.String());
            DropForeignKey("dbo.Customers", "DayOfWeekId", "dbo.DaysOfWeeks");
            DropIndex("dbo.Customers", new[] { "DayOfWeekId" });
            AlterColumn("dbo.Customers", "DayOfWeekId", c => c.Int());
            RenameColumn(table: "dbo.Customers", name: "DayOfWeekId", newName: "DayOfWeek_Id");
            CreateIndex("dbo.Customers", "DayOfWeek_Id");
            AddForeignKey("dbo.Customers", "DayOfWeek_Id", "dbo.DaysOfWeeks", "Id");
        }
    }
}
