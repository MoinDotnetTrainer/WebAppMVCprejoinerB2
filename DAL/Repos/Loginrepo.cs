using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class Loginrepo : ILogin
    {
        public readonly AppDatabase _db;
        public Loginrepo(AppDatabase db)
        {
            _db = db;
        }

        public bool AuthenticateUser(LoginModel obj)
        {
            var res = (from s in _db.employees select s).Any(x => x.Email == obj.Email && x.Password == obj.Password);
            return res; 
        }
    }
}
