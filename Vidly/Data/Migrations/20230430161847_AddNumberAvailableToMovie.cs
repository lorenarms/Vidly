using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNumberAvailableToMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "NumberAvailable",
                table: "Movies",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.Sql("UPDATE Movies SET NumberAvailable = NumberInStock");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberAvailable",
                table: "Movies");
        }
    }
}
