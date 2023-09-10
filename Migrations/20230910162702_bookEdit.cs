using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAPI_R53_A.Migrations
{
    public partial class bookEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookRacks_Shelfs_ShelfId",
                table: "BookRacks");

            migrationBuilder.AddColumn<string>(
                name: "AgreementFileName",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CoverFileName",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EBookFileName",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BookRacks_Shelfs_ShelfId",
                table: "BookRacks",
                column: "ShelfId",
                principalTable: "Shelfs",
                principalColumn: "ShelfId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookRacks_Shelfs_ShelfId",
                table: "BookRacks");

            migrationBuilder.DropColumn(
                name: "AgreementFileName",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CoverFileName",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "EBookFileName",
                table: "Books");

            migrationBuilder.AddForeignKey(
                name: "FK_BookRacks_Shelfs_ShelfId",
                table: "BookRacks",
                column: "ShelfId",
                principalTable: "Shelfs",
                principalColumn: "ShelfId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
