namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedforeignkeytocustomer : DbMigration
    {
        public override void Up()
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
            CreateIndex("dbo.Customers", "TrashPickupId");
            AddForeignKey("dbo.Customers", "TrashPickupId", "dbo.TrashPickups", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "TrashPickupId", "dbo.TrashPickups");
            DropIndex("dbo.Customers", new[] { "TrashPickupId" });
            DropColumn("dbo.Customers", "TrashPickupId");
            DropTable("dbo.TrashPickups");
        }
    }
}
