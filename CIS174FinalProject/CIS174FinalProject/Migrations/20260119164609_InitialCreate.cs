using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CIS174FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ISBN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ISBN);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Harper", "Lee" },
                    { 2, "George", "Orwell" },
                    { 3, "F. Scott", "Fitzgerald" },
                    { 4, "J.K.", "Rowling" },
                    { 5, "J.R.R.", "Tolkien" },
                    { 6, "Jane", "Austen" },
                    { 7, "Herman", "Melville" },
                    { 8, "Leo", "Tolstoy" },
                    { 9, "Charles", "Dickens" },
                    { 10, "Mark", "Twain" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Fiction" },
                    { 2, "Science Fiction" },
                    { 3, "Classic Literature" },
                    { 4, "Fantasy" },
                    { 5, "Dystopian" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ISBN", "AuthorId", "GenreId", "Title", "Year" },
                values: new object[,]
                {
                    { "978-0-06-112008-4", 1, 3, "To Kill a Mockingbird", 1960 },
                    { "978-0-14-039084-2", 10, 3, "The Adventures of Huckleberry Finn", 1884 },
                    { "978-0-14-044793-4", 8, 3, "War and Peace", 1869 },
                    { "978-0-14-143951-8", 6, 3, "Pride and Prejudice", 1813 },
                    { "978-0-14-143974-7", 9, 3, "Great Expectations", 1861 },
                    { "978-0-14-243724-7", 7, 3, "Moby-Dick", 1851 },
                    { "978-0-439-13959-8", 4, 4, "Harry Potter and the Sorcerer's Stone", 1997 },
                    { "978-0-452-28423-4", 2, 5, "1984", 1949 },
                    { "978-0-618-00222-1", 5, 4, "The Lord of the Rings", 1954 },
                    { "978-0-7432-7356-5", 3, 3, "The Great Gatsby", 1925 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
