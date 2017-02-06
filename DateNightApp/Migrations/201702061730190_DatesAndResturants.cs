namespace DateNightApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatesAndResturants : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DayOfDate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        IsChatty = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsArtsy = c.Boolean(nullable: false),
                        RestaurantId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Restaurants", t => t.RestaurantId, cascadeDelete: true)
                .Index(t => t.RestaurantId);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RestaurantType = c.String(),
                        BeforeAfterEating = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dates", "RestaurantId", "dbo.Restaurants");
            DropIndex("dbo.Dates", new[] { "RestaurantId" });
            DropTable("dbo.Restaurants");
            DropTable("dbo.Dates");
        }
    }
}
