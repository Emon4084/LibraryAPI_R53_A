﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using R53_Group_A.DAL;

#nullable disable

namespace LibraryAPI_R53_A.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20230826145415_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
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

                    b.Property<string>("SecurityStamp")
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

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
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

            modelBuilder.Entity("R53_Group_A.Models.Author", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorID"), 1L, 1);

                    b.Property<string>("Biography")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorID");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("R53_Group_A.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("DDCCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
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

                    b.Property<decimal?>("RentPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TotalCopies")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("R53_Group_A.Models.BookAuthor", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("BookId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("BooksAuthors");
                });

            modelBuilder.Entity("R53_Group_A.Models.BookCopy", b =>
                {
                    b.Property<int>("BookCopyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookCopyId"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int?>("BookId1")
                        .HasColumnType("int");

                    b.Property<string>("CallNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<int>("ShelfId")
                        .HasColumnType("int");

                    b.Property<int?>("ShelfId1")
                        .HasColumnType("int");

                    b.Property<int?>("condition")
                        .HasColumnType("int");

                    b.HasKey("BookCopyId");

                    b.HasIndex("BookId");

                    b.HasIndex("BookId1");

                    b.HasIndex("ShelfId");

                    b.HasIndex("ShelfId1");

                    b.ToTable("BookCopy");
                });

            modelBuilder.Entity("R53_Group_A.Models.BookFloor", b =>
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

                    b.ToTable("BookFloor");
                });

            modelBuilder.Entity("R53_Group_A.Models.BookRack", b =>
                {
                    b.Property<int>("BookRackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookRackId"), 1L, 1);

                    b.Property<string>("BookRackName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShelfId")
                        .HasColumnType("int");

                    b.Property<int?>("ShelfId1")
                        .HasColumnType("int");

                    b.HasKey("BookRackId");

                    b.HasIndex("ShelfId");

                    b.HasIndex("ShelfId1");

                    b.ToTable("BookRack");
                });

            modelBuilder.Entity("R53_Group_A.Models.BookReview", b =>
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

                    b.ToTable("BookReview");
                });

            modelBuilder.Entity("R53_Group_A.Models.BookWishlist", b =>
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

                    b.ToTable("BookWishlist");
                });

            modelBuilder.Entity("R53_Group_A.Models.BorrowedBook", b =>
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

                    b.ToTable("BorrowedBook");
                });

            modelBuilder.Entity("R53_Group_A.Models.Category", b =>
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

                    b.ToTable("Category");
                });

            modelBuilder.Entity("R53_Group_A.Models.Fine", b =>
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

                    b.ToTable("Fine");
                });

            modelBuilder.Entity("R53_Group_A.Models.Inspection", b =>
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

                    b.ToTable("Inspection");
                });

            modelBuilder.Entity("R53_Group_A.Models.Publisher", b =>
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

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("R53_Group_A.Models.Shelf", b =>
                {
                    b.Property<int>("ShelfId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShelfId"), 1L, 1);

                    b.Property<int>("BookFloorId")
                        .HasColumnType("int");

                    b.Property<int?>("BookFloorId1")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ShelfName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShelfId");

                    b.HasIndex("BookFloorId");

                    b.HasIndex("BookFloorId1");

                    b.ToTable("Shelf");
                });

            modelBuilder.Entity("R53_Group_A.Models.Subcategory", b =>
                {
                    b.Property<int>("SubcategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubcategoryId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId1")
                        .HasColumnType("int");

                    b.Property<string>("DDCCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubcategoryId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CategoryId1");

                    b.ToTable("Subcategory");
                });

            modelBuilder.Entity("R53_Group_A.Models.SubscriptionPlan", b =>
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

                    b.ToTable("SubscriptionPlan");
                });

            modelBuilder.Entity("R53_Group_A.Models.UserPreference", b =>
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

                    b.Property<string>("UserInfoId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserPreferenceId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserInfoId");

                    b.HasIndex("UserInfoId1");

                    b.ToTable("UserPreference");
                });

            modelBuilder.Entity("R53_Group_A.Models.UserInfo", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<bool>("IsSubscribed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfileImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SubscriptionId")
                        .HasColumnType("int");

                    b.Property<string>("TransactionId")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("RoleId");

                    b.HasIndex("SubscriptionId");

                    b.HasDiscriminator().HasValue("UserInfo");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("R53_Group_A.Models.Book", b =>
                {
                    b.HasOne("R53_Group_A.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("R53_Group_A.Models.Publisher", "Publisher")
                        .WithMany()
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Category");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("R53_Group_A.Models.BookAuthor", b =>
                {
                    b.HasOne("R53_Group_A.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("R53_Group_A.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("R53_Group_A.Models.BookCopy", b =>
                {
                    b.HasOne("R53_Group_A.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("R53_Group_A.Models.Book", null)
                        .WithMany("Copies")
                        .HasForeignKey("BookId1");

                    b.HasOne("R53_Group_A.Models.Shelf", "Shelf")
                        .WithMany()
                        .HasForeignKey("ShelfId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("R53_Group_A.Models.Shelf", null)
                        .WithMany("Copies")
                        .HasForeignKey("ShelfId1");

                    b.Navigation("Book");

                    b.Navigation("Shelf");
                });

            modelBuilder.Entity("R53_Group_A.Models.BookRack", b =>
                {
                    b.HasOne("R53_Group_A.Models.Shelf", "Shelf")
                        .WithMany()
                        .HasForeignKey("ShelfId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("R53_Group_A.Models.Shelf", null)
                        .WithMany("BookRacks")
                        .HasForeignKey("ShelfId1");

                    b.Navigation("Shelf");
                });

            modelBuilder.Entity("R53_Group_A.Models.BookReview", b =>
                {
                    b.HasOne("R53_Group_A.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("R53_Group_A.Models.UserInfo", "UserInfo")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Book");

                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("R53_Group_A.Models.BookWishlist", b =>
                {
                    b.HasOne("R53_Group_A.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("R53_Group_A.Models.UserInfo", "UserInfo")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Book");

                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("R53_Group_A.Models.BorrowedBook", b =>
                {
                    b.HasOne("R53_Group_A.Models.BookCopy", "BookCopy")
                        .WithMany()
                        .HasForeignKey("BookCopyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("R53_Group_A.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("R53_Group_A.Models.UserInfo", "UserInfo")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Book");

                    b.Navigation("BookCopy");

                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("R53_Group_A.Models.Fine", b =>
                {
                    b.HasOne("R53_Group_A.Models.BorrowedBook", "BorrowedBook")
                        .WithMany()
                        .HasForeignKey("BorrowedBookId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BorrowedBook");
                });

            modelBuilder.Entity("R53_Group_A.Models.Inspection", b =>
                {
                    b.HasOne("R53_Group_A.Models.BookCopy", "BookCopy")
                        .WithMany()
                        .HasForeignKey("BookCopyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("R53_Group_A.Models.BorrowedBook", "BorrowedBook")
                        .WithMany()
                        .HasForeignKey("BorrowBookId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BookCopy");

                    b.Navigation("BorrowedBook");
                });

            modelBuilder.Entity("R53_Group_A.Models.Shelf", b =>
                {
                    b.HasOne("R53_Group_A.Models.BookFloor", "BookFloor")
                        .WithMany()
                        .HasForeignKey("BookFloorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("R53_Group_A.Models.BookFloor", null)
                        .WithMany("Shelfes")
                        .HasForeignKey("BookFloorId1");

                    b.Navigation("BookFloor");
                });

            modelBuilder.Entity("R53_Group_A.Models.Subcategory", b =>
                {
                    b.HasOne("R53_Group_A.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("R53_Group_A.Models.Category", null)
                        .WithMany("Subcategories")
                        .HasForeignKey("CategoryId1");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("R53_Group_A.Models.UserPreference", b =>
                {
                    b.HasOne("R53_Group_A.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("R53_Group_A.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("R53_Group_A.Models.UserInfo", "UserInfo")
                        .WithMany()
                        .HasForeignKey("UserInfoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("R53_Group_A.Models.UserInfo", null)
                        .WithMany("UserPreferences")
                        .HasForeignKey("UserInfoId1");

                    b.Navigation("Author");

                    b.Navigation("Category");

                    b.Navigation("UserInfo");
                });

            modelBuilder.Entity("R53_Group_A.Models.UserInfo", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("R53_Group_A.Models.SubscriptionPlan", "SubscriptionPlan")
                        .WithMany()
                        .HasForeignKey("SubscriptionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("SubscriptionPlan");
                });

            modelBuilder.Entity("R53_Group_A.Models.Book", b =>
                {
                    b.Navigation("Copies");
                });

            modelBuilder.Entity("R53_Group_A.Models.BookFloor", b =>
                {
                    b.Navigation("Shelfes");
                });

            modelBuilder.Entity("R53_Group_A.Models.Category", b =>
                {
                    b.Navigation("Subcategories");
                });

            modelBuilder.Entity("R53_Group_A.Models.Shelf", b =>
                {
                    b.Navigation("BookRacks");

                    b.Navigation("Copies");
                });

            modelBuilder.Entity("R53_Group_A.Models.UserInfo", b =>
                {
                    b.Navigation("UserPreferences");
                });
#pragma warning restore 612, 618
        }
    }
}
