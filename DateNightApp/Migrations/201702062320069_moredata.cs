namespace DateNightApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class moredata : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DatePrices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatePriceRanage = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Dates", "DatePriceId", c => c.Int(nullable: false));
            CreateIndex("dbo.Dates", "DatePriceId");
            AddForeignKey("dbo.Dates", "DatePriceId", "dbo.DatePrices", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dates", "DatePriceId", "dbo.DatePrices");
            DropIndex("dbo.Dates", new[] { "DatePriceId" });
            DropColumn("dbo.Dates", "DatePriceId");
            DropTable("dbo.DatePrices");
        }
    }
}
