using LibraryAPI_R53_A.Core.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI_R53_A.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthor> BooksAuthors { get; set; }
        public DbSet<BookReview> BookReviews { get; set; }
        public DbSet<BorrowedBook> BorrowedBooks { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<BookCopy> Copies { get; set; }
        public DbSet<Fine> Fines { get; set; }
        public DbSet<BookFloor> BookFloors { get; set; }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Shelf> Shelfs { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<SubscriptionPlan> SubscriptionPlans { get; set; }

        //public DbSet<ApplicationUser> UserInfos { get; set; }
        public DbSet<UserPreference> UserPreferences { get; set; }
        public DbSet<BookWishlist> BookWishlists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(e => e.AuthorId);
                entity.Property(e => e.AuthorId).IsRequired();
            });



            //Book Entity Relation
            modelBuilder.Entity<Book>().HasOne(p => p.Publisher).WithMany().HasForeignKey(p => p.PublisherId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Book>().HasOne(p => p.Category).WithMany().HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.Restrict);

            //Book Author 

            modelBuilder.Entity<BookAuthor>(entity =>
            {
                entity.HasKey(e => new { e.BookId, e.AuthorId });
                entity.HasOne(e => e.Book)
                 .WithMany(e => e.BookAuthor)
                 .HasForeignKey(e => e.BookId).OnDelete(DeleteBehavior.Restrict); ;

                entity.HasOne(e => e.Author)
                    .WithMany(e=>e.BookAuthor)
                    .HasForeignKey(e => e.AuthorId).OnDelete(DeleteBehavior.Restrict);
            });

            //BookCopy
            modelBuilder.Entity<BookCopy>().HasOne(p => p.Book).WithMany().HasForeignKey(p => p.BookId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<BookCopy>().HasOne(p => p.Shelf).WithMany().HasForeignKey(p => p.ShelfId).OnDelete(DeleteBehavior.Restrict);

            //Book Rack
            modelBuilder.Entity<BookRack>().HasOne(p => p.Shelf).WithMany().HasForeignKey(p => p.ShelfId).OnDelete(DeleteBehavior.Restrict);

            //Book Review
            modelBuilder.Entity<BookReview>().HasOne(p => p.Book).WithMany().HasForeignKey(p => p.BookId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<BookReview>().HasOne(p => p.UserInfo).WithMany().HasForeignKey(p => p.UserId).OnDelete(DeleteBehavior.Restrict);

            //BookWishlist
            modelBuilder.Entity<BookWishlist>().HasOne(p => p.UserInfo).WithMany().HasForeignKey(p => p.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<BookWishlist>().HasOne(p => p.Book).WithMany().HasForeignKey(p => p.BookId).OnDelete(DeleteBehavior.Restrict);

            //BorrowedBook
            modelBuilder.Entity<BorrowedBook>().HasOne(p => p.UserInfo).WithMany().HasForeignKey(p => p.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<BorrowedBook>().HasOne(p => p.Book).WithMany().HasForeignKey(p => p.BookId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<BorrowedBook>().HasOne(p => p.BookCopy).WithMany().HasForeignKey(p => p.BookCopyId).OnDelete(DeleteBehavior.Restrict);

            //fine
            modelBuilder.Entity<Fine>().HasOne(p => p.BorrowedBook).WithMany().HasForeignKey(p => p.BorrowedBookId).OnDelete(DeleteBehavior.Restrict);

            //Inspection
            modelBuilder.Entity<Inspection>().HasOne(p => p.BookCopy).WithMany().HasForeignKey(p => p.BookCopyId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Inspection>().HasOne(p => p.BorrowedBook).WithMany().HasForeignKey(p => p.BorrowBookId).OnDelete(DeleteBehavior.Restrict);

            //Shelf
            modelBuilder.Entity<Shelf>().HasOne(p => p.BookFloor).WithMany().HasForeignKey(p => p.BookFloorId).OnDelete(DeleteBehavior.Restrict);

            //Subcategory
            modelBuilder.Entity<Subcategory>().HasOne(p => p.Category).WithMany().HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.Restrict);

            //UserInfo
            modelBuilder.Entity<ApplicationUser>().HasOne(p => p.Role).WithMany().HasForeignKey(p => p.RoleId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ApplicationUser>().HasOne(p => p.SubscriptionPlan).WithMany().HasForeignKey(p => p.SubscriptionId).OnDelete(DeleteBehavior.Restrict);

            //UserPreference
            modelBuilder.Entity<UserPreference>().HasOne(p => p.UserInfo).WithMany().HasForeignKey(p => p.UserInfoId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<UserPreference>().HasOne(p => p.Category).WithMany().HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<UserPreference>().HasOne(p => p.Author).WithMany().HasForeignKey(p => p.AuthorId).OnDelete(DeleteBehavior.Restrict);


            base.OnModelCreating(modelBuilder);
        }
    }
}