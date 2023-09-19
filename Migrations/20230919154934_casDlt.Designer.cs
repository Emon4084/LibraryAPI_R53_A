﻿// <auto-generated />
using System;
using LibraryAPI_R53_A.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryAPI_R53_A.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230919154934_casDlt")]
    partial class casDlt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSubscribed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfileImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubscriptionId")
                        .HasColumnType("int");

                    b.Property<string>("TransactionId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("RoleId");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"), 1L, 1);

                    b.Property<string>("Biography")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"), 1L, 1);

                    b.Property<string>("AgreementFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("BookPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CoverFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DDCCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EBookFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Edition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDigital")
                        .HasColumnType("bit");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishedYear")
                        .HasColumnType("datetime2");

                    b.Property<bool>("PublisherAgreement")
                        .HasColumnType("bit");

                    b.Property<int?>("PublisherId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TotalCopies")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.BookAuthor", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("BooksAuthors");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.BookCopy", b =>
                {
                    b.Property<int>("BookCopyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookCopyId"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("CallNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DDC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<int>("ShelfId")
                        .HasColumnType("int");

                    b.Property<int?>("condition")
                        .HasColumnType("int");

                    b.HasKey("BookCopyId");

                    b.HasIndex("BookId");

                    b.HasIndex("ShelfId");

                    b.ToTable("Copies");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.BookFloor", b =>
                {
                    b.Property<int>("BookFloorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookFloorId"), 1L, 1);

                    b.Property<string>("BookFloorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("BookFloorId");

                    b.ToTable("BookFloors");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.BookRack", b =>
                {
                    b.Property<int>("BookRackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookRackId"), 1L, 1);

                    b.Property<string>("BookRackName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShelfId")
                        .HasColumnType("int");

                    b.HasKey("BookRackId");

                    b.HasIndex("ShelfId");

                    b.ToTable("BookRacks");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.BookReview", b =>
                {
                    b.Property<int>("BookReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookReviewId"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BookReviewId");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("BookReviews");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.BookWishlist", b =>
                {
                    b.Property<int>("BookWishlistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookWishlistId"), 1L, 1);

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BookWishlistId");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("BookWishlists");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.BorrowedBook", b =>
                {
                    b.Property<int>("BorrowedBookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BorrowedBookId"), 1L, 1);

                    b.Property<DateTime?>("ActualReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BookCopyId")
                        .HasColumnType("int");

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BorrowDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsReturned")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BorrowedBookId");

                    b.HasIndex("BookCopyId");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("BorrowedBooks");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DDCCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("CategoryId");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.Fine", b =>
                {
                    b.Property<int>("FineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FineId"), 1L, 1);

                    b.Property<int>("BorrowedBookId")
                        .HasColumnType("int");

                    b.Property<decimal>("FineAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("PaidDate")
                        .HasColumnType("datetime2");

                    b.HasKey("FineId");

                    b.HasIndex("BorrowedBookId");

                    b.ToTable("Fines");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.Inspection", b =>
                {
                    b.Property<int>("InspectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InspectionId"), 1L, 1);

                    b.Property<int>("BookCopyId")
                        .HasColumnType("int");

                    b.Property<int>("BorrowBookId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("InspectionId");

                    b.HasIndex("BookCopyId");

                    b.HasIndex("BorrowBookId");

                    b.ToTable("Inspections");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.Publisher", b =>
                {
                    b.Property<int>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PublisherId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublisherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PublisherId");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.Shelf", b =>
                {
                    b.Property<int>("ShelfId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShelfId"), 1L, 1);

                    b.Property<int>("BookFloorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ShelfName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShelfId");

                    b.HasIndex("BookFloorId");

                    b.ToTable("Shelfs");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.Subcategory", b =>
                {
                    b.Property<int>("SubcategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubcategoryId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("DDCCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubcategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Subcategories");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.SubscriptionPlan", b =>
                {
                    b.Property<int>("SubscriptionPlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubscriptionPlanId"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PlanDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlanName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PlanPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SubscriptionPlanId");

                    b.ToTable("SubscriptionPlans");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.UserPreference", b =>
                {
                    b.Property<int>("UserPreferenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserPreferenceId"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UserInfoId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserPreferenceId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserInfoId");

                    b.ToTable("UserPreferences");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.ApplicationUser", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("LibraryAPI_R53_A.Core.Domain.SubscriptionPlan", "SubscriptionPlan")
                        .WithMany("Users")
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("SubscriptionPlan");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.Book", b =>
                {
                    b.HasOne("LibraryAPI_R53_A.Core.Domain.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryAPI_R53_A.Core.Domain.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId");

                    b.Navigation("Category");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.BookAuthor", b =>
                {
                    b.HasOne("LibraryAPI_R53_A.Core.Domain.Author", "Author")
                        .WithMany("BookAuthor")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryAPI_R53_A.Core.Domain.Book", "Book")
                        .WithMany("BookAuthor")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.BookCopy", b =>
                {
                    b.HasOne("LibraryAPI_R53_A.Core.Domain.Book", "Book")
                        .WithMany("Copies")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryAPI_R53_A.Core.Domain.Shelf", "Shelf")
                        .WithMany("Copies")
                        .HasForeignKey("ShelfId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Shelf");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.BookRack", b =>
                {
                    b.HasOne("LibraryAPI_R53_A.Core.Domain.Shelf", "Shelf")
                        .WithMany("BookRacks")
                        .HasForeignKey("ShelfId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shelf");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.BookReview", b =>
                {
                    b.HasOne("LibraryAPI_R53_A.Core.Domain.Book", "Book")
                        .WithMany("BookReviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryAPI_R53_A.Core.Domain.ApplicationUser", "UserInfo")
                        .WithMany("BookReviews")
                        .HasForeignKey("UserId");

                    b.Navigation("Book");

                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.BookWishlist", b =>
                {
                    b.HasOne("LibraryAPI_R53_A.Core.Domain.Book", "Book")
                        .WithMany("BookWishlists")
                        .HasForeignKey("BookId");

                    b.HasOne("LibraryAPI_R53_A.Core.Domain.ApplicationUser", "UserInfo")
                        .WithMany("BookWishlists")
                        .HasForeignKey("UserId");

                    b.Navigation("Book");

                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.BorrowedBook", b =>
                {
                    b.HasOne("LibraryAPI_R53_A.Core.Domain.BookCopy", "BookCopy")
                        .WithMany("BorrowBook")
                        .HasForeignKey("BookCopyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryAPI_R53_A.Core.Domain.Book", "Book")
                        .WithMany("BorrowedBooks")
                        .HasForeignKey("BookId");

                    b.HasOne("LibraryAPI_R53_A.Core.Domain.ApplicationUser", "UserInfo")
                        .WithMany("BorrowedBooks")
                        .HasForeignKey("UserId");

                    b.Navigation("Book");

                    b.Navigation("BookCopy");

                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.Fine", b =>
                {
                    b.HasOne("LibraryAPI_R53_A.Core.Domain.BorrowedBook", "BorrowedBook")
                        .WithMany("Fine")
                        .HasForeignKey("BorrowedBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BorrowedBook");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.Inspection", b =>
                {
                    b.HasOne("LibraryAPI_R53_A.Core.Domain.BookCopy", "BookCopy")
                        .WithMany("Inspections")
                        .HasForeignKey("BookCopyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("LibraryAPI_R53_A.Core.Domain.BorrowedBook", "BorrowedBook")
                        .WithMany("Inspection")
                        .HasForeignKey("BorrowBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookCopy");

                    b.Navigation("BorrowedBook");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.Shelf", b =>
                {
                    b.HasOne("LibraryAPI_R53_A.Core.Domain.BookFloor", "BookFloor")
                        .WithMany("Shelves")
                        .HasForeignKey("BookFloorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookFloor");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.Subcategory", b =>
                {
                    b.HasOne("LibraryAPI_R53_A.Core.Domain.Category", "Category")
                        .WithMany("Subcategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.UserPreference", b =>
                {
                    b.HasOne("LibraryAPI_R53_A.Core.Domain.Author", "Author")
                        .WithMany("UserPreferences")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryAPI_R53_A.Core.Domain.Category", "Category")
                        .WithMany("UserPreferences")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryAPI_R53_A.Core.Domain.ApplicationUser", "UserInfo")
                        .WithMany("UserPreferences")
                        .HasForeignKey("UserInfoId");

                    b.Navigation("Author");

                    b.Navigation("Category");

                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("LibraryAPI_R53_A.Core.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LibraryAPI_R53_A.Core.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryAPI_R53_A.Core.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("LibraryAPI_R53_A.Core.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.ApplicationUser", b =>
                {
                    b.Navigation("BookReviews");

                    b.Navigation("BookWishlists");

                    b.Navigation("BorrowedBooks");

                    b.Navigation("UserPreferences");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.Author", b =>
                {
                    b.Navigation("BookAuthor");

                    b.Navigation("UserPreferences");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.Book", b =>
                {
                    b.Navigation("BookAuthor");

                    b.Navigation("BookReviews");

                    b.Navigation("BookWishlists");

                    b.Navigation("BorrowedBooks");

                    b.Navigation("Copies");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.BookCopy", b =>
                {
                    b.Navigation("BorrowBook");

                    b.Navigation("Inspections");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.BookFloor", b =>
                {
                    b.Navigation("Shelves");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.BorrowedBook", b =>
                {
                    b.Navigation("Fine");

                    b.Navigation("Inspection");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.Category", b =>
                {
                    b.Navigation("Books");

                    b.Navigation("Subcategories");

                    b.Navigation("UserPreferences");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.Publisher", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.Shelf", b =>
                {
                    b.Navigation("BookRacks");

                    b.Navigation("Copies");
                });

            modelBuilder.Entity("LibraryAPI_R53_A.Core.Domain.SubscriptionPlan", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
