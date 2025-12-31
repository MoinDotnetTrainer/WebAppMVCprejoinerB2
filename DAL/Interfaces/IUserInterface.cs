using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{

    public interface IUserInterface
    {
        //adstract methods

        // getting all user info 
        Task<IEnumerable<Users>> GetAllUsers();



        // inserting user info
        Task InsertUser(Users users);

        // get user data based in id
        Task<Users?> GetUserbyID(int UserId);


        // update user 
        Task UpdateUsers(Users users);


        // delete user

        Task DeleteUsers(int UserId);


        bool Login(LoginModel obj);

        Task SaveAsync();

    }
}
