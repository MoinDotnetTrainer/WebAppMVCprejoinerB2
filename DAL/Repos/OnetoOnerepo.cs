using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class OnetoOnerepo : IOneToone
    {
        public readonly AppDatabase _db;
        public OnetoOnerepo(AppDatabase db) { 
        _db = db;   
        }

        public async Task<IEnumerable<User>> GetUserData() {
            return await _db.user.Include("UserProfile").ToListAsync();
        }
        public async Task<IEnumerable<UserProfile>> GetUserProfileData()
        {
            return await _db.UserProfile.Include("User").ToListAsync();
        }

    }


}
