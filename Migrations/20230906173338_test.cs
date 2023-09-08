using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAPI_R53_A.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_RoleId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_SubscriptionPlans_SubscriptionPlanId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_BookRack_Shelfs_ShelfId",
                table: "BookRack");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SubscriptionPlanId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookRack",
                table: "BookRack");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "BooksAuthors");

            migrationBuilder.DropColumn(
                name: "SubscriptionPlanId",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "BookRack",
                newName: "BookRacks");

            migrationBuilder.RenameIndex(
                name: "IX_BookRack_ShelfId",
                table: "BookRacks",
                newName: "IX_BookRacks_ShelfId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookRacks",
                table: "BookRacks",
                column: "BookRackId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SubscriptionId",
                table: "AspNetUsers",
                column: "SubscriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_RoleId",
                table: "AspNetUsers",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SubscriptionPlans_SubscriptionId",
                table: "AspNetUsers",
                column: "SubscriptionId",
                principalTable: "SubscriptionPlans",
                principalColumn: "SubscriptionPlanId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookRacks_Shelfs_ShelfId",
                table: "BookRacks",
                column: "ShelfId",
                principalTable: "Shelfs",
                principalColumn: "ShelfId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_RoleId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_SubscriptionPlans_SubscriptionId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_BookRacks_Shelfs_ShelfId",
                table: "BookRacks");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SubscriptionId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookRacks",
                table: "BookRacks");

            migrationBuilder.RenameTable(
                name: "BookRacks",
                newName: "BookRack");

            migrationBuilder.RenameIndex(
                name: "IX_BookRacks_ShelfId",
                table: "BookRack",
                newName: "IX_BookRack_ShelfId");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "BooksAuthors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionPlanId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookRack",
                table: "BookRack",
                column: "BookRackId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SubscriptionPlanId",
                table: "AspNetUsers",
                column: "SubscriptionPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_RoleId",
                table: "AspNetUsers",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SubscriptionPlans_SubscriptionPlanId",
                table: "AspNetUsers",
                column: "SubscriptionPlanId",
                principalTable: "SubscriptionPlans",
                principalColumn: "SubscriptionPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookRack_Shelfs_ShelfId",
                table: "BookRack",
                column: "ShelfId",
                principalTable: "Shelfs",
                principalColumn: "ShelfId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
