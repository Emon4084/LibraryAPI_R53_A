﻿using LibraryAPI_R53_A.Core.Domain;
using LibraryAPI_R53_A.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI_R53_A.Persistence.Repositories
{
    public class CategoryRepository : ICategory
    {
        private readonly ApplicationDbContext _context;


        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;

        }


        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _context.Categorys.ToListAsync();
        }

        public async Task<Category?> Get(int id)
        {
            var Category = await _context.Categorys.FindAsync(id);
            return Category;
        }

        public async Task<Category?> Post(Category entity)
        {
            if (_context.Categorys.Any(p => p.CategoryName == entity.CategoryName))
            {
                return null;
            }
            _context.Categorys.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task Put(Category Category)
        {
            _context.Categorys.Update(Category);
            await _context.SaveChangesAsync();

        }

        public async Task Delete(int id)
        {
            var Category = await _context.Categorys.FindAsync(id);
            if (Category != null)
            {
                _context.Categorys.Remove(Category);
                await _context.SaveChangesAsync();
            }
        }
    }
}
