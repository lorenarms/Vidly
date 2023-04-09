using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsersAndRolesTutorial.Data.Migrations
{
    public partial class BuildAndAddDataToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "33213605-9b69-4be5-8a01-b1ae778eab40", "9794f469-8476-4319-821d-4e1e7f4d82d7", "Admin", "ADMIN" },
                    { "3d844ad7-0eee-46f0-b13b-251edd16ca29", "11d4cd08-5db1-42bd-b2df-c67a651c4a95", "Sales", "SALES" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "317dfd54-ac59-459b-9248-c45f00ba036c", 0, "99e7d9be-5581-4683-a674-6874be8ba516", "adminUser@hotmail.com", false, false, null, "ADMINUSER@HOTMAIL.COM", "ADMINUSER", null, null, false, "56670977-16e4-4892-8bec-82215541d442", false, "adminUser" },
                    { "8c6e0a30-44f1-406c-b158-ffb821bacd91", 0, "de426ac1-b274-433d-974c-0318f84cc5fe", "userWithoutRole@hotmail.com", false, false, null, "USERWITHOUTROLE@HOTMAIL.COM", "USERWITHOUTROLE", null, null, false, "bcc86c99-6b89-4072-9602-4af84f49d32d", false, "userWithoutRole" },
                    { "ee9d9834-ac8e-40c7-a9f9-0d1324cbfa9d", 0, "f75ef302-5efb-4831-adbe-d5fa384c37f6", "salesUser@hotmail.com", false, false, null, "SALESUSER@HOTMAIL.COM", "SALESUSER", null, null, false, "bd0420ef-7c84-40b5-8b1a-d54a875136c0", false, "salesUser" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "33213605-9b69-4be5-8a01-b1ae778eab40", "317dfd54-ac59-459b-9248-c45f00ba036c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3d844ad7-0eee-46f0-b13b-251edd16ca29", "ee9d9834-ac8e-40c7-a9f9-0d1324cbfa9d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33213605-9b69-4be5-8a01-b1ae778eab40", "317dfd54-ac59-459b-9248-c45f00ba036c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3d844ad7-0eee-46f0-b13b-251edd16ca29", "ee9d9834-ac8e-40c7-a9f9-0d1324cbfa9d" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c6e0a30-44f1-406c-b158-ffb821bacd91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33213605-9b69-4be5-8a01-b1ae778eab40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d844ad7-0eee-46f0-b13b-251edd16ca29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "317dfd54-ac59-459b-9248-c45f00ba036c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee9d9834-ac8e-40c7-a9f9-0d1324cbfa9d");
        }
    }
}
