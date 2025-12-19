using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class BookRepo :IBookRepo
    {
        public readonly AppDatabase _db;
        public BookRepo(AppDatabase db) { 
         _db = db;       
        }  
        public async Task AddBook(Book book)
        {
            await _db.book.AddAsync(book);
            await _db.SaveChangesAsync();
        }
        public async Task<IList<Book>> GetAllBooks()
        {
            return await _db.book.ToListAsync();
        }
        public async Task<Book> GetDataBookByID(int BookID)
        {
            return await _db.book.FindAsync(BookID);
        }
        public async Task UpdateBook(Book book)
        {
            _db.book.Update(book);
            await _db.SaveChangesAsync();
        }
        public async Task DeleteBook(int BookID)
        {
            var res = await _db.book.FindAsync(BookID);
            if (res != null)
            {
                _db.book.Remove(res);
                await _db.SaveChangesAsync();
            }
        }
    }
}
