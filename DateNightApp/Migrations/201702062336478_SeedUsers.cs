namespace DateNightApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e2b1b029-5cfb-47ba-836e-296dae555319', N'Guest@gmail.com', 0, N'AErId6aGGiutRQuJJzwFzWvqhMGTh072AKRimJjnh1SC+J0iavULA2xVee5YP5YYUg==', N'5637297c-69e1-491b-9942-ab6f15e79548', NULL, 0, 0, NULL, 1, 0, N'Guest@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ee2ee565-dd0a-4843-826d-7b35b29217a4', N'Admin@DNA.com', 0, N'AESmLz+xw/Ul7h7lk2YX2lOzWUy/b8dovxXpjdTvT0kKXZ5BFlzcZ8h6VpzM0EHjRg==', N'a5771f00-0265-4288-99fb-4a0e6adff815', NULL, 0, 0, NULL, 1, 0, N'Admin@DNA.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'cbe390cd-14d3-447e-a321-914f0af15c58', N'Admin')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ee2ee565-dd0a-4843-826d-7b35b29217a4', N'cbe390cd-14d3-447e-a321-914f0af15c58')
");
        }
        
        public override void Down()
        {
        }
    }
}
