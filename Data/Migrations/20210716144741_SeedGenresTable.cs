using Microsoft.EntityFrameworkCore.Migrations;

namespace GigHub.Data.Migrations
{
    public partial class SeedGenresTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Jazz')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'RnB')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Alternative Rock')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Pop')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Afro Soul')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Amapiano')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Genres WHERE ID > 0");
        }
    }
}
