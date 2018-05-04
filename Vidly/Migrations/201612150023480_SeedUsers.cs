namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"

                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'24b40741-6fc9-41a4-ab43-a69fd02a971d', N'guest@vidly.com', 0, N'AChh6K8FlpPJ2CIk9r5Ls3/PewiSWJi8FwR93ZuaBbL20sJtTWYF08kejrpAGbRr9A==', N'429563e4-69f0-4838-b0df-a27a58838bd4', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'34d0088b-b485-46d0-ad98-ff6eddac1cf3', N'admin@vidly.com', 0, N'AD074iIp14H6m9UAtIj2vgDORq+bdbXF4MAlN0EJP6V5JYqyEvfv4yYI9hKTdT1nnA==', N'a7eae845-b235-468d-b48e-6092a12836df', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                    
                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e8f09a62-14cc-4c83-a59d-78176401bd03', N'CanManageMovies')

                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'34d0088b-b485-46d0-ad98-ff6eddac1cf3', N'e8f09a62-14cc-4c83-a59d-78176401bd03')

            ");
        }

        public override void Down()
        {
        }
    }
}
