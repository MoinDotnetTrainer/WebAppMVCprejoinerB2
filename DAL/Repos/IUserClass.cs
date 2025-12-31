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

    public class IUserClass : IUserInterface
    {
        public readonly AppDatabase _context;
        public IUserClass(AppDatabase context) { _context = context; }

        public async Task<IEnumerable<Users>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task InsertUser(Users users)
        {
            await _context.Users.AddAsync(users);
        }


        public async Task<Users?> GetUserbyID(int UserId)
        {
            var users = await _context.Users.FirstOrDefaultAsync(x => x.UserId == UserId);
            return users;
        }


        public async Task UpdateUsers(Users users)
        {
            _context.Users.Update(users);
        }


        public async Task DeleteUsers(int UserId)
        {

            var res = await _context.Users.FindAsync(UserId);
            if (res != null)
            {
                _context.Users.Remove(res);
            }
        }

        public bool Login(LoginModel obj)
        {
            bool res = _context.Users.Any(x => x.Email == obj.Email && x.Password == obj.Password);
            return res;
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
