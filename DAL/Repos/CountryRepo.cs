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
    public class CountryRepo :IOneToMany
    {
        public readonly AppDatabase _db;
        public CountryRepo(AppDatabase db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Country>> GetCountries()
        {
            return await _db.Country.Include(x=>x.States).ToListAsync();
        }
    }
}
