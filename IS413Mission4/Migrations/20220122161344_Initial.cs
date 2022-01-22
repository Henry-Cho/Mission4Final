using Microsoft.EntityFrameworkCore.Migrations;

namespace IS413Mission4.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<string>(maxLength: 4, nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Note = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Note", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action/Adventure", "Chris Columbus", false, "Logan Kim", "For FHE", "PG", "Harry Potter and the Chamber of Secrets", "2002" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Note", "Rating", "Title", "Year" },
                values: new object[] { 2, "Action/Adventure", "Jon Favreau", false, "Wayne Park", "For his dating", "PG-13", "Iron Man", "2008" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Note", "Rating", "Title", "Year" },
                values: new object[] { 3, "Drama", "Richard Curtis", true, "Yes", "For fun", "R", "About Time", "2013" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
