namespace DateNightApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedRestuarantTypes : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT RestaurantTypes ON INSERT INTO RestaurantTypes(Id, RestaurantTypeName) VALUES (1, 'Chill')");
            Sql("SET IDENTITY_INSERT RestaurantTypes ON INSERT INTO RestaurantTypes(Id, RestaurantTypeName) VALUES (2, 'Romantic')");
            Sql("SET IDENTITY_INSERT RestaurantTypes ON INSERT INTO RestaurantTypes(Id, RestaurantTypeName) VALUES (3, 'High Energy')");

        }
        
        public override void Down()
        {
        }
    }
}
