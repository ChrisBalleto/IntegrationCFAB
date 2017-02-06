namespace DateNightApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedAtmospherAddedCost : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Dates", "DateAtmosphereId", "dbo.DateAtmospheres");
            DropForeignKey("dbo.Dates", "DateTimeOfDay_Id", "dbo.DateTimeOfDays");
            DropIndex("dbo.Dates", new[] { "DateAtmosphereId" });
            DropIndex("dbo.Dates", new[] { "DateTimeOfDay_Id" });
            RenameColumn(table: "dbo.Dates", name: "DateTimeOfDay_Id", newName: "DateTimeOfDayId");
            AddColumn("dbo.DatePrices", "DatePriceRange", c => c.String());
            AlterColumn("dbo.Dates", "DateTimeOfDayId", c => c.Int(nullable: false));
            CreateIndex("dbo.Dates", "DateTimeOfDayId");
            AddForeignKey("dbo.Dates", "DateTimeOfDayId", "dbo.DateTimeOfDays", "Id", cascadeDelete: true);
            DropColumn("dbo.Dates", "DateAtmosphereId");
            DropColumn("dbo.DatePrices", "DatePriceRanage");
            DropTable("dbo.DateAtmospheres");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DateAtmospheres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateAtmosphereType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.DatePrices", "DatePriceRanage", c => c.String());
            AddColumn("dbo.Dates", "DateAtmosphereId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Dates", "DateTimeOfDayId", "dbo.DateTimeOfDays");
            DropIndex("dbo.Dates", new[] { "DateTimeOfDayId" });
            AlterColumn("dbo.Dates", "DateTimeOfDayId", c => c.Int());
            DropColumn("dbo.DatePrices", "DatePriceRange");
            RenameColumn(table: "dbo.Dates", name: "DateTimeOfDayId", newName: "DateTimeOfDay_Id");
            CreateIndex("dbo.Dates", "DateTimeOfDay_Id");
            CreateIndex("dbo.Dates", "DateAtmosphereId");
            AddForeignKey("dbo.Dates", "DateTimeOfDay_Id", "dbo.DateTimeOfDays", "Id");
            AddForeignKey("dbo.Dates", "DateAtmosphereId", "dbo.DateAtmospheres", "Id", cascadeDelete: true);
        }
    }
}
