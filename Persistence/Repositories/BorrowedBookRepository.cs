﻿using LibraryAPI_R53_A.Core.Domain;
using LibraryAPI_R53_A.Core.Interfaces;
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
        //public async Task CreateBorrowBook(BorrowedBook borrowedBook)
        //{
        //   _context.BorrowedBooks.Add(borrowedBook);
        //    await _context.SaveChangesAsync();
        //}
        public async Task<BorrowedBook?> Post(BorrowedBook borrowedBook)
        {
            _context.BorrowedBooks.Add(borrowedBook);
            await _context.SaveChangesAsync();
            return borrowedBook;
        }
        public Task Put(BorrowedBook entities)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BorrowedBook>> GetAllRequestedBooksByUserName(string userName)
        {
            return await _context.BorrowedBooks
                .Include(b => b.Book)
                .Include(b => b.BookCopy)
                .Where(b => b.UserInfo.UserName == userName && b.Status == "Requested")
                .ToListAsync();

        } 
        public async Task<IEnumerable<BorrowedBook>> GetAllCancelledBooksByUserName()
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

        public async Task<BorrowedBook> ApproveBorrowedBookAsync(BorrowedBook borrowedBook)
        {
           
            borrowedBook.BorrowDate = DateTime.UtcNow;
            borrowedBook.DueDate = DateTime.UtcNow.AddDays(7);


            borrowedBook.Status = "Approved";

            await _context.SaveChangesAsync();

            return borrowedBook; 
        }


        public async Task<BorrowedBook?> Get(int id)
        {
            var bR = await _context.BorrowedBooks.FindAsync(id);
            return bR;
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
    }
}
