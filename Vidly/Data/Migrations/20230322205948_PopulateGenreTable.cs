using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Data.Migrations
{
    /// <inheritdoc />
    public partial class PopulateGenreTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (1, 'Comedy')");
	        migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (2, 'Action')");
	        migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (3, 'Family')");
	        migrationBuilder.Sql("INSERT INTO Genre (Id, Name) VALUES (4, 'Romance')");
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
