namespace DateNightApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1a915c30-0da5-4360-88d9-f1fda5c3c4ca', N'Guest@gmail.com', 0, N'AIz+qdU27gKHcNapy0Ud+D8667253E1Nr1C/Uu6tOQ9rRZ+oNb16U3/W5KYtka6lAg==', N'd5b75475-d580-46d4-88c0-dc4d8c5a0fea', NULL, 0, 0, NULL, 1, 0, N'Guest@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e26e1313-c644-4f6b-ad46-1d5c2aaadb87', N'Admin@DNA.com', 0, N'AH9FeVqTLtUi5PlhtkRPNteYl1r8w2Gd3KOaWsqD9ZGn3z6V5ZOjbmhhXfmWw/w53A==', N'7bf50694-bb4a-4f5e-91c1-612cada5a233', NULL, 0, 0, NULL, 1, 0, N'Admin@DNA.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'af4146d5-a397-4f92-aeda-e2a15a550151', N'Admin')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e26e1313-c644-4f6b-ad46-1d5c2aaadb87', N'af4146d5-a397-4f92-aeda-e2a15a550151')
");
        }
        
        public override void Down()
        {
        }
    }
}
