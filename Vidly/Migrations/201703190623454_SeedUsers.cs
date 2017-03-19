namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2d97d4d7-b739-495d-8501-62981a13a3f3', N'admin@vidly.com', 0, N'ANaFkPBHpqEwfGZaZYXhgvv2bPRo2a25EneschSAq/55VXXXmn2K/hsCw5ii8QRcfg==', N'a5818444-2355-4a5e-a9d4-94402abdd3a6', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'af0b328f-3eb6-46bc-be09-09fadc75e07e', N'guest@vidly.com', 0, N'ADBJQghKVL0+FrEOKaCKNHKJ35N0361q2QqvCukT6rCKmdCK2Ep7aSKHdu6yy0D93A==', N'e25337e3-186e-4a83-bd81-0d826c087dfc', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'77118c61-4e84-4445-bfad-b1d692d451a9', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2d97d4d7-b739-495d-8501-62981a13a3f3', N'77118c61-4e84-4445-bfad-b1d692d451a9')

");
        }
        
        public override void Down()
        {
        }
    }
}
