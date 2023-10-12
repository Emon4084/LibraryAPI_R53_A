using LibraryAPI_R53_A.Core.Domain;
using LibraryAPI_R53_A.Core.Entities;
using LibraryAPI_R53_A.Core.Interfaces;
using LibraryAPI_R53_A.Helpers;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI_R53_A.Persistence.Repositories
{
    public class BorrowedBookRepository : IBorrowBook
    {
        private readonly ApplicationDbContext _context;

        public BorrowedBookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<BorrowedBook?> Post(BorrowedBook borrowedBook)
        {
            _context.BorrowedBooks.Add(borrowedBook);
            await _context.SaveChangesAsync();
            return borrowedBook;
        }

        public async Task<IEnumerable<BorrowedBook>> GetAllRequestedBooksByUserName(string userName)
        {
            return await _context.BorrowedBooks
                .Include(b => b.Book)
                .Include(b => b.BookCopy)
                .Where(b => b.UserInfo.UserName == userName && b.Status == "Requested")
                .ToListAsync();
        }

        public async Task<IEnumerable<BorrowedBook>> GetAllRequestedBooksByUserId(string userId)
        {
            return await _context.BorrowedBooks
                .Include(b => b.Book)
                .Include(b => b.BookCopy)
                .Where(b => b.UserInfo.Id == userId)
                .ToListAsync();
        }


        public async Task<IEnumerable<BorrowedBook>> GetAllByUserName(string userName)
        {
            return await _context.BorrowedBooks
                .Include(b => b.Book)
                .Include(b => b.BookCopy)
                .Where(b => b.UserInfo.UserName == userName)
                .ToListAsync();
        }
        public async Task<IEnumerable<BorrowedBook>> GetAllApprovedBooks()
        {
            return await _context.BorrowedBooks
                .Include(b => b.Book)
                .Include(b => b.BookCopy)
                .Where(b => b.Status == "Approved")
                .ToListAsync();

        }

        public async Task<IEnumerable<BorrowedBook>> GetAllCancelledBooks()
        {
            return await _context.BorrowedBooks
                .Include(b => b.Book)
                .Include(b => b.BookCopy)
                .Where(b => b.Status == "Cancelled")
                .ToListAsync();
        }

        public async Task<IEnumerable<BorrowedBook>> GetAll()
        {
            return await _context.BorrowedBooks
                .Include(b => b.Book)
                .Include(b => b.BookCopy)
                .ToListAsync();
        }

        //public async Task<BorrowedBook> ApproveBorrowedBookAsync(BorrowedBook borrowedBook)
        //{
        //    //borrowedBook.BorrowDate = DateTime.Now;
        //    //borrowedBook.DueDate = DateTime.Now.AddDays(7);

        //    //borrowedBook.Status = "Approved";
        //    //borrowedBook.Comment = "";
        //    //borrowedBook.Invoices


        //    //await _context.SaveChangesAsync();

        //    return borrowedBook;
        //}
        //public async Task<BorrowedBook> ApproveBorrowedBookAsync(BorrowedBook borrowedBook)
        //{
        //    if (borrowedBook == null)
        //    {
        //        throw new InvalidOperationException("BorrowedBook must have a valid value.");
        //    }

        //    // Update the BorrowedBook properties
        //    borrowedBook.BorrowDate = DateTime.Now;
        //    borrowedBook.DueDate = DateTime.Now.AddDays(7);
        //    borrowedBook.Status = "Approved";
        //    borrowedBook.Comment = "";

        //    // Create an invoice for the approved book request
        //    var invoice = new Invoice
        //    {
        //        BorrowedBook = borrowedBook,
        //        UserId = borrowedBook.UserId,
        //        Payment = borrowedBook?.Book?.BookPrice, // Set payment as the book price
        //        Refund = borrowedBook?.Book?.BookPrice * 0.7m, // Set refund as 70% of the book price
        //        TransactionDate = DateTime.Now
        //    };

        //    // Add the invoice to the context and save changes
        //    _context.Invoices.Add(invoice);
        //    await _context.SaveChangesAsync();

        //    return borrowedBook;
        //}
        public async Task<BorrowedBook> ApproveBorrowedBookAsync(BorrowedBook borrowedBook)
        {
            if (borrowedBook == null)
            {
                throw new InvalidOperationException("BorrowedBook must have a valid value.");
            }

            // Update the BorrowedBook properties
            borrowedBook.BorrowDate = DateTime.Now;
            borrowedBook.DueDate = DateTime.Now.AddDays(7);
            borrowedBook.Status = "Approved";
            borrowedBook.Comment = "";

            // Check if the user has a subscription
            //bool isSubscribedUser = borrowedBook.UserInfo.IsSubscribed;

            var invoice = new Invoice();
            if (borrowedBook.UserInfo?.IsSubscribed == true)
            {

                invoice.BorrowedBook = borrowedBook;
                invoice.UserId = borrowedBook.UserId;
                invoice.Payment = 0;
                invoice.Refund = 0;
                invoice.TransactionDate = DateTime.Now;

            }
            else
            {

                invoice.BorrowedBook = borrowedBook;
                invoice.UserId = borrowedBook.UserId;
                invoice.Payment = (decimal)borrowedBook.Book.BookPrice;
                invoice.Refund = borrowedBook?.Book?.BookPrice * 0.7m;
                invoice.TransactionDate = DateTime.Now;

            }
            _context.Invoices.Add(invoice);

            // Add the invoice to the context and save changes
            await _context.SaveChangesAsync();

            return borrowedBook;
        }


        public async Task<BorrowedBook> CancelBorrowedBookAsync(BorrowedBook borrowedBook)
        {

            borrowedBook.DueDate = null;
            borrowedBook.Status = "Cancelled";

            await _context.SaveChangesAsync();

            return borrowedBook;
        }

        public async Task<BorrowedBook> ReturnBook(BorrowedBook borrowedBook)
        {
            borrowedBook.DueDate = borrowedBook.DueDate;
            borrowedBook.ActualReturnDate = DateTime.Now;
            borrowedBook.Status = "Returned";


            // Calculate the fine amount
            var fineCalculator = new FineCalculator();
            decimal fineAmount = fineCalculator.CalculateFine(borrowedBook);



            // Find the corresponding invoice
            var invoice = await _context.Invoices.FirstOrDefaultAsync(i => i.BorrowId == borrowedBook.BorrowedBookId);

            if (invoice != null)
            {
                if (borrowedBook.UserInfo?.IsSubscribed == true)
                {
                    // Subscribed user: Pay only the fine (if available) and update the invoice
                    if (fineAmount > 0)
                    {
                        invoice.Fine = fineAmount;
                        invoice.Payment = fineAmount;
                        invoice.TransactionDate= DateTime.Now;
                    }
                }
                else
                {
                    
                    decimal payment = (decimal)borrowedBook.Book.BookPrice; 

                   
                    decimal refund = payment - fineAmount;

                    // Ensuring refund is non-negative
                    refund = Math.Max(0, payment*0.7M);

                    invoice.Fine = fineAmount;
                    invoice.Payment = payment;
                    invoice.Refund = refund;
                    invoice.TransactionDate = DateTime.Now;
                }

                // Save changes to the database
                await _context.SaveChangesAsync();
            }

            return borrowedBook;
        }

        public async Task<BorrowedBook?> Get(int id)
        {
            var borrowedBook = await _context.BorrowedBooks
   .Include(b => b.UserInfo)
   .Include(bb=>bb.Book).FirstOrDefaultAsync(b => b.BorrowedBookId == id);
            return borrowedBook;
        }




        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BorrowedBook> Search(string searchString)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BorrowedBook> GetActive()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BorrowedBook> GetInactive()
        {
            throw new NotImplementedException();
        }
        public Task Put(BorrowedBook entities)
        {
            throw new NotImplementedException();
        }
    }
}
