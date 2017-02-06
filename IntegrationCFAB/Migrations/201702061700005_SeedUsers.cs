namespace IntegrationCFAB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6597c607-8e01-42dd-978d-f77492f93e64', N'Guest@gmail.com', 0, N'AMSPtAI+IvXdndYAlGADmVohDNe2W1U1NObjBeQAz7fMcBndfKoa/7xL46MYq45NwQ==', N'bd024f57-5881-420f-b0d5-149321d157ba', NULL, 0, 0, NULL, 1, 0, N'Guest@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9b8f129c-1527-4241-a5a6-41f6b9d69ea2', N'admin1@CFAB.com', 0, N'AA8TySlKi5du3Mm2piY3hbb9YQu9lAn740NYycZRhuXni/+F+nX/x7Uf2R6f/itubg==', N'1bd586b0-50b4-4c14-90cc-0d8c8f650c88', NULL, 0, 0, NULL, 1, 0, N'admin1@CFAB.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'10eef1ba-93c8-40b8-bafd-73bd8b4e270b', N'Admin')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9b8f129c-1527-4241-a5a6-41f6b9d69ea2', N'10eef1ba-93c8-40b8-bafd-73bd8b4e270b')
");
        }
        
        public override void Down()
        {
        }
    }
}
