namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Customers", name: "DaysOfWeek_Id", newName: "DayOfWeek_Id");
            RenameIndex(table: "dbo.Customers", name: "IX_DaysOfWeek_Id", newName: "IX_DayOfWeek_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Customers", name: "IX_DayOfWeek_Id", newName: "IX_DaysOfWeek_Id");
            RenameColumn(table: "dbo.Customers", name: "DayOfWeek_Id", newName: "DaysOfWeek_Id");
        }
    }
}
