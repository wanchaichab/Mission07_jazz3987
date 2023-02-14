using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_jazz3987.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieForms",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<string>(nullable: true),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieForms", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "MovieForms",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Anime", "Makoto Shinkai", "", "", "", "PG-13", "Kimi no na wa", 2016 });

            migrationBuilder.InsertData(
                table: "MovieForms",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Anime", "Makoto Shinkai", "No", "", "", "PG-13", "Tenki no Ko", 2019 });

            migrationBuilder.InsertData(
                table: "MovieForms",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Comedy/Drama", "Daniel Kwan", "", "Jacob", "Very trippy", "R", "Everything Everywhere All at Once", 2022 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieForms");
        }
    }
}
