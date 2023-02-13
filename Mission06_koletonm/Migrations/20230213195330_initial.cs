using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_koletonm.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MoviesId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<ushort>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MoviesId);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MoviesId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action/Adventure", "Anthony Russo", false, "", "Best movie!", "PG-13", "Avengers: Endgame", (ushort)2019 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MoviesId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Family/Comdey", "Mark Dindal", false, "", "A Classic!", "G", "Emporer's New Groove", (ushort)2000 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MoviesId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "War/Drama", "Niki Caro", false, "", "Tragic, but so moving", "PG-13", "The Zookeeper's Wife", (ushort)2017 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
