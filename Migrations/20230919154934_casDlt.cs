using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryAPI_R53_A.Migrations
{
    public partial class casDlt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_SubscriptionPlans_SubscriptionId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_BookReviews_AspNetUsers_UserId",
                table: "BookReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_BookReviews_Books_BookId",
                table: "BookReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categorys_CategoryId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_BookWishlists_AspNetUsers_UserId",
                table: "BookWishlists");

            migrationBuilder.DropForeignKey(
                name: "FK_BookWishlists_Books_BookId",
                table: "BookWishlists");

            migrationBuilder.DropForeignKey(
                name: "FK_BorrowedBooks_AspNetUsers_UserId",
                table: "BorrowedBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_BorrowedBooks_Books_BookId",
                table: "BorrowedBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_BorrowedBooks_Copies_BookCopyId",
                table: "BorrowedBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Copies_Books_BookId",
                table: "Copies");

            migrationBuilder.DropForeignKey(
                name: "FK_Copies_Shelfs_ShelfId",
                table: "Copies");

            migrationBuilder.DropForeignKey(
                name: "FK_Fines_BorrowedBooks_BorrowedBookId",
                table: "Fines");

            migrationBuilder.DropForeignKey(
                name: "FK_Inspections_BorrowedBooks_BorrowBookId",
                table: "Inspections");

            migrationBuilder.DropForeignKey(
                name: "FK_Shelfs_BookFloors_BookFloorId",
                table: "Shelfs");

            migrationBuilder.DropForeignKey(
                name: "FK_Subcategories_Categorys_CategoryId",
                table: "Subcategories");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPreferences_AspNetUsers_UserInfoId",
                table: "UserPreferences");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPreferences_Authors_AuthorId",
                table: "UserPreferences");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPreferences_Categorys_CategoryId",
                table: "UserPreferences");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SubscriptionPlans_SubscriptionId",
                table: "AspNetUsers",
                column: "SubscriptionId",
                principalTable: "SubscriptionPlans",
                principalColumn: "SubscriptionPlanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookReviews_AspNetUsers_UserId",
                table: "BookReviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookReviews_Books_BookId",
                table: "BookReviews",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categorys_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookWishlists_AspNetUsers_UserId",
                table: "BookWishlists",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookWishlists_Books_BookId",
                table: "BookWishlists",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowedBooks_AspNetUsers_UserId",
                table: "BorrowedBooks",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowedBooks_Books_BookId",
                table: "BorrowedBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowedBooks_Copies_BookCopyId",
                table: "BorrowedBooks",
                column: "BookCopyId",
                principalTable: "Copies",
                principalColumn: "BookCopyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Copies_Books_BookId",
                table: "Copies",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Copies_Shelfs_ShelfId",
                table: "Copies",
                column: "ShelfId",
                principalTable: "Shelfs",
                principalColumn: "ShelfId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fines_BorrowedBooks_BorrowedBookId",
                table: "Fines",
                column: "BorrowedBookId",
                principalTable: "BorrowedBooks",
                principalColumn: "BorrowedBookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inspections_BorrowedBooks_BorrowBookId",
                table: "Inspections",
                column: "BorrowBookId",
                principalTable: "BorrowedBooks",
                principalColumn: "BorrowedBookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shelfs_BookFloors_BookFloorId",
                table: "Shelfs",
                column: "BookFloorId",
                principalTable: "BookFloors",
                principalColumn: "BookFloorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subcategories_Categorys_CategoryId",
                table: "Subcategories",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPreferences_AspNetUsers_UserInfoId",
                table: "UserPreferences",
                column: "UserInfoId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPreferences_Authors_AuthorId",
                table: "UserPreferences",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPreferences_Categorys_CategoryId",
                table: "UserPreferences",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_SubscriptionPlans_SubscriptionId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_BookReviews_AspNetUsers_UserId",
                table: "BookReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_BookReviews_Books_BookId",
                table: "BookReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categorys_CategoryId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_BookWishlists_AspNetUsers_UserId",
                table: "BookWishlists");

            migrationBuilder.DropForeignKey(
                name: "FK_BookWishlists_Books_BookId",
                table: "BookWishlists");

            migrationBuilder.DropForeignKey(
                name: "FK_BorrowedBooks_AspNetUsers_UserId",
                table: "BorrowedBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_BorrowedBooks_Books_BookId",
                table: "BorrowedBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_BorrowedBooks_Copies_BookCopyId",
                table: "BorrowedBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Copies_Books_BookId",
                table: "Copies");

            migrationBuilder.DropForeignKey(
                name: "FK_Copies_Shelfs_ShelfId",
                table: "Copies");

            migrationBuilder.DropForeignKey(
                name: "FK_Fines_BorrowedBooks_BorrowedBookId",
                table: "Fines");

            migrationBuilder.DropForeignKey(
                name: "FK_Inspections_BorrowedBooks_BorrowBookId",
                table: "Inspections");

            migrationBuilder.DropForeignKey(
                name: "FK_Shelfs_BookFloors_BookFloorId",
                table: "Shelfs");

            migrationBuilder.DropForeignKey(
                name: "FK_Subcategories_Categorys_CategoryId",
                table: "Subcategories");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPreferences_AspNetUsers_UserInfoId",
                table: "UserPreferences");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPreferences_Authors_AuthorId",
                table: "UserPreferences");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPreferences_Categorys_CategoryId",
                table: "UserPreferences");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_SubscriptionPlans_SubscriptionId",
                table: "AspNetUsers",
                column: "SubscriptionId",
                principalTable: "SubscriptionPlans",
                principalColumn: "SubscriptionPlanId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookReviews_AspNetUsers_UserId",
                table: "BookReviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookReviews_Books_BookId",
                table: "BookReviews",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categorys_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "PublisherId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookWishlists_AspNetUsers_UserId",
                table: "BookWishlists",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookWishlists_Books_BookId",
                table: "BookWishlists",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowedBooks_AspNetUsers_UserId",
                table: "BorrowedBooks",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowedBooks_Books_BookId",
                table: "BorrowedBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowedBooks_Copies_BookCopyId",
                table: "BorrowedBooks",
                column: "BookCopyId",
                principalTable: "Copies",
                principalColumn: "BookCopyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Copies_Books_BookId",
                table: "Copies",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Copies_Shelfs_ShelfId",
                table: "Copies",
                column: "ShelfId",
                principalTable: "Shelfs",
                principalColumn: "ShelfId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fines_BorrowedBooks_BorrowedBookId",
                table: "Fines",
                column: "BorrowedBookId",
                principalTable: "BorrowedBooks",
                principalColumn: "BorrowedBookId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inspections_BorrowedBooks_BorrowBookId",
                table: "Inspections",
                column: "BorrowBookId",
                principalTable: "BorrowedBooks",
                principalColumn: "BorrowedBookId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shelfs_BookFloors_BookFloorId",
                table: "Shelfs",
                column: "BookFloorId",
                principalTable: "BookFloors",
                principalColumn: "BookFloorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subcategories_Categorys_CategoryId",
                table: "Subcategories",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPreferences_AspNetUsers_UserInfoId",
                table: "UserPreferences",
                column: "UserInfoId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPreferences_Authors_AuthorId",
                table: "UserPreferences",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPreferences_Categorys_CategoryId",
                table: "UserPreferences",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
