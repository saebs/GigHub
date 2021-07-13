using System.Data.SqlTypes;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GigHb.Data.Migrations
{
    public partial class PopulateGenresTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Afro Soul')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Hip Hop')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'House')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Amapiano')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Genres WHERE Id in (1, 2, 3, 4)");

        }
    }
}
