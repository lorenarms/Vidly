using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUserAndAdminUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'7cb83d48-82d0-47ea-a253-79a343979ec1', N'User', N'USER', NULL)
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'abcfe18d-8f52-4edc-93e7-b569ed501ef7', N'Admin', N'ADMIN', NULL)
            ");
            
            migrationBuilder.Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'352ddcd2-b06c-42c0-aa3d-f574bc32dc5e', N'user@vidly.com', N'USER@VIDLY.COM', N'user@vidly.com', N'USER@VIDLY.COM', 0, N'AQAAAAIAAYagAAAAELOCVWJSPiWHr8u0AD1+F3EPer4bGn4ay6mTpVt4yQKZX4qubsNXo/0FoyPrAB1tOw==', N'2QHWTQI5TU4UQO646T472IPJH3NYZQ3Z', N'c3609012-7fc7-4f5f-ab87-5bdfc7e58d36', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', N'Lawrence', N'A')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [FirstName], [LastName]) VALUES (N'b331042b-cf10-4360-b43e-c45c93422985', N'admin@vidly.com', N'ADMIN@VIDLY.COM', N'admin@vidly.com', N'ADMIN@VIDLY.COM', 0, N'AQAAAAIAAYagAAAAEIQkcNBScTb7aYlLVsoYMAj0tFoNCwk6huTd6+Rhx399ZjPp3nCaAvtN7SwvRiTQjw==', N'M5WOSA72X3JPKFDGERUZNJHP34M6JVAI', N'faaf00b6-b3d7-4e5a-abd2-174bc05e8cea', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', N'Lawrence', N'A')
            ");

            migrationBuilder.Sql(@"
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'352ddcd2-b06c-42c0-aa3d-f574bc32dc5e', N'7cb83d48-82d0-47ea-a253-79a343979ec1')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b331042b-cf10-4360-b43e-c45c93422985', N'abcfe18d-8f52-4edc-93e7-b569ed501ef7')
            ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
