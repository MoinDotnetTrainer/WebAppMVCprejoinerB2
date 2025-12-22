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
    public class LoadingRepo : ILoading
    {
        public readonly AppDatabase _db;
        public  LoadingRepo(AppDatabase db)
        {
            _db = db;
        }
        //public async Task<IEnumerable<Models.Books>> GetAllBooks()
        //{
        //    return await _db.Books.ToListAsync();
        //}

        public async Task<IEnumerable<Models.Books>> GetAllBooks()
        {
            return await _db.Books.Include(x=>x.Author).Include(x=>x.Language).ToListAsync();
        }
    }
}
