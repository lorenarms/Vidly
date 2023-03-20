using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Data.Migrations
{
    /// <inheritdoc />
    public partial class PopulateMebershipTypeName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.Sql("UPDATE MembershipType SET MembershipTypeName = 'Pay as You Go' WHERE Id = 1");
	        migrationBuilder.Sql("UPDATE MembershipType SET MembershipTypeName = 'Monthly' WHERE Id = 2");
	        migrationBuilder.Sql("UPDATE MembershipType SET MembershipTypeName = 'Quarterly' WHERE Id = 3");
	        migrationBuilder.Sql("UPDATE MembershipType SET MembershipTypeName = 'Yearly' WHERE Id = 4");
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
