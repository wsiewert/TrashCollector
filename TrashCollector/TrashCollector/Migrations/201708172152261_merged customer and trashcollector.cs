namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mergedcustomerandtrashcollector : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "TrashPickupId", "dbo.TrashPickups");
            DropIndex("dbo.Customers", new[] { "TrashPickupId" });
            AddColumn("dbo.Customers", "AmountOwed", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Customers", "PickupDay", c => c.String());
            AddColumn("dbo.Customers", "ChangePickup", c => c.String());
            DropColumn("dbo.Customers", "TrashPickupId");
            DropTable("dbo.TrashPickups");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TrashPickups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AmountOwed = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PickupDay = c.String(),
                        ChangePickup = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "TrashPickupId", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "ChangePickup");
            DropColumn("dbo.Customers", "PickupDay");
            DropColumn("dbo.Customers", "AmountOwed");
            CreateIndex("dbo.Customers", "TrashPickupId");
            AddForeignKey("dbo.Customers", "TrashPickupId", "dbo.TrashPickups", "Id", cascadeDelete: true);
        }
    }
}
