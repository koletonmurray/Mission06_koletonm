using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_koletonm.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieCategories",
                columns: table => new
                {
                    MovieCategoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCategories", x => x.MovieCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<ushort>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true),
                    MovieCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_Movies_MovieCategories_MovieCategoryId",
                        column: x => x.MovieCategoryId,
                        principalTable: "MovieCategories",
                        principalColumn: "MovieCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "MovieCategoryId", "MovieCategoryName" },
                values: new object[] { 1, "Action/Adventure" });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "MovieCategoryId", "MovieCategoryName" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "MovieCategoryId", "MovieCategoryName" },
                values: new object[] { 3, "Drama" });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "MovieCategoryId", "MovieCategoryName" },
                values: new object[] { 4, "Family" });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "MovieCategoryId", "MovieCategoryName" },
                values: new object[] { 5, "Horror" });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "MovieCategoryId", "MovieCategoryName" },
                values: new object[] { 6, "Musical" });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "MovieCategoryId", "MovieCategoryName" },
                values: new object[] { 7, "Mystery/Thriller" });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "MovieCategoryId", "MovieCategoryName" },
                values: new object[] { 8, "Romance" });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "MovieCategoryId", "MovieCategoryName" },
                values: new object[] { 9, "Science Fiction" });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "MovieCategoryId", "MovieCategoryName" },
                values: new object[] { 10, "Sports" });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "MovieCategoryId", "MovieCategoryName" },
                values: new object[] { 11, "War" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Director", "Edited", "LentTo", "MovieCategoryId", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Anthony Russo", false, "", 1, "Best movie!", "PG-13", "Avengers: Endgame", (ushort)2019 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Director", "Edited", "LentTo", "MovieCategoryId", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Mark Dindal", false, "", 2, "A Classic!", "G", "Emporer's New Groove", (ushort)2000 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Director", "Edited", "LentTo", "MovieCategoryId", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Niki Caro", false, "", 4, "Tragic, but so moving", "PG-13", "The Zookeeper's Wife", (ushort)2017 });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_MovieCategoryId",
                table: "Movies",
                column: "MovieCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "MovieCategories");
        }
    }
}
