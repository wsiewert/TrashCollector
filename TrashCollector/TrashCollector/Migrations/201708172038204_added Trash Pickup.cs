namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedTrashPickup : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "AmountOwed");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "AmountOwed", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
