using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAPI_R53_A.Migrations
{
    public partial class authorCascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksAuthors_Authors_AuthorId",
                table: "BooksAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksAuthors_Books_BookId",
                table: "BooksAuthors");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksAuthors_Authors_AuthorId",
                table: "BooksAuthors",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksAuthors_Books_BookId",
                table: "BooksAuthors",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksAuthors_Authors_AuthorId",
                table: "BooksAuthors");

            migrationBuilder.DropForeignKey(
                name: "FK_BooksAuthors_Books_BookId",
                table: "BooksAuthors");

            migrationBuilder.AddForeignKey(
                name: "FK_BooksAuthors_Authors_AuthorId",
                table: "BooksAuthors",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksAuthors_Books_BookId",
                table: "BooksAuthors",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
