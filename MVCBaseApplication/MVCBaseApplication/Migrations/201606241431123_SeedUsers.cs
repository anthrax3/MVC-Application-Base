namespace MVCBaseApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Address], [PostCode], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [BirthDay]) VALUES (N'689ec0eb-94d3-4077-8b40-b722867ac84c', N'Faz', N'Ahmed', N'Richmond upon River', N'TW21 1EE', N'fazahmed786@hotmail.com', 0, N'AJIrnUOn5+SDu0XdDrgwsAL0SMufvdfalJzDHxxB2wOZ0OJyPaBO4etmVm66WpjmIw==', N'3beaf5ac-8662-441d-bdb5-757b1f3cd251', NULL, 0, 0, NULL, 1, 0, N'fazahmed786@hotmail.com', N'1990-04-04 00:00:00')
INSERT INTO [dbo].[AspNetUsers] ([Id], [FirstName], [LastName], [Address], [PostCode], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [BirthDay]) VALUES (N'9cdb1b49-48e3-4354-b3b6-076a24dcb3e4', N'Aamir', N'Khan', N'123 sample house', N'hb2 4hs', N'aamir.khan@hotmail.com', 0, N'AMzw+lx30LUcJiu4oZTUp2iz/fo3TSJlW0zxlGCZ4y6iwJO3J6wVdkOMfdEZKMFvvA==', N'5c945bc8-bca6-4599-baf4-cbada45b17cf', NULL, 0, 0, NULL, 1, 0, N'aamir.khan@hotmail.com', N'1991-01-01 00:00:00')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'38a3d66d-96f1-4d7d-a489-4b44a7a3d117', N'ApplicationManager')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'689ec0eb-94d3-4077-8b40-b722867ac84c', N'38a3d66d-96f1-4d7d-a489-4b44a7a3d117')


");
        }
        
        public override void Down()
        {
        }
    }
}
