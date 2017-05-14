namespace _123456.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8999d132-7779-48d9-9840-916b6c991dbd', N'admin@631three.co.uk', 0, N'ACL3DnGQw1LvXfwoBhve/s/acdFeXX5jpywHkLDCVqsvYxwKWUS9ihx6PYQYWmiG0g==', N'a371bf95-dd36-46de-8020-f29f6d05a09a', NULL, 0, 0, NULL, 1, 0, N'admin@631three.co.uk')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ae3e65cd-2fff-4610-92ba-7e841598083a', N'beattie.edwin@gmail.com', 0, N'AEoPHqvoZq+YwnrY8U7Q4taxzkNICC50M++bP9h5CpagnbeUU0hQbsfIDL/sCzAMtQ==', N'4c5a5874-3c31-453c-99d0-ddf7e49e09c4', NULL, 0, 0, NULL, 1, 0, N'beattie.edwin@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'35ee12ca-91e8-4c30-995c-c68069374694', N'PortalManager')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8999d132-7779-48d9-9840-916b6c991dbd', N'35ee12ca-91e8-4c30-995c-c68069374694')

");
        }
        
        public override void Down()
        {
        }
    }
}
