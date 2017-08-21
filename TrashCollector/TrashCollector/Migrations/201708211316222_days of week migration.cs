namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class daysofweekmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DaysOfWeeks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Day = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DaysOfWeeks");
        }
    }
}
