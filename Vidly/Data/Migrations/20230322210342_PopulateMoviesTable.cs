using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Data.Migrations
{
    /// <inheritdoc />
    public partial class PopulateMoviesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.Sql("INSERT INTO Movies (Name, DateAdded, DateReleased, GenreId, NumberInStock) VALUES ('Hangover', '5/4/2016', '11/6/2009', 1, 5)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, DateAdded, DateReleased, GenreId, NumberInStock) VALUES ('Die Hard', '5/4/2016', '12/1/1980', 2, 3)");
	        migrationBuilder.Sql("INSERT INTO Movies (Name, DateAdded, DateReleased, GenreId, NumberInStock) VALUES ('The Terminator', '5/4/2016', '8/1/1983', 2, 0)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, DateAdded, DateReleased, GenreId, NumberInStock) VALUES ('Toy Story', '5/4/2016', '12/24/1998', 3, 2)");
            migrationBuilder.Sql("INSERT INTO Movies (Name, DateAdded, DateReleased, GenreId, NumberInStock) VALUES ('Titanic', '5/4/2016', '5/1/1997', 4, 6)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
