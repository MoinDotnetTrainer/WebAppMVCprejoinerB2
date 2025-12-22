using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class Cityrepo : ICityPin
    {
        public readonly Models.AppDatabase? _appDatabase;
        public Cityrepo(Models.AppDatabase appDatabase)
        {
            _appDatabase = appDatabase;
        }
        public async Task<IEnumerable<Models.City>> GetCity()
        {
            return await _appDatabase.City.Include(x => x.Pincode).ToListAsync();
        }
        public async Task<IEnumerable<Models.Pincode>> GetPin()
        {
            return await _appDatabase.Pincode.Include(x => x.City).ToListAsync();
        }
    }
}
