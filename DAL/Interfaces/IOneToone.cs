using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IOneToone
    {
        Task<IEnumerable<UserProfile>> GetUserProfileData();
        Task<IEnumerable<User>> GetUserData();
    }

    public interface IOneToMany
    {
        Task<IEnumerable<Country>> GetCountries();
     
    }
}
