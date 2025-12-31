using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ITaskInterface
    {
        Task<IEnumerable<UsersTask>> GetAllUsersTask();
        Task InsertUsersTask(UsersTask UsersTask);
        Task<UsersTask?> GetUsersTaskbyID(int TaskID);
        Task UpdateUsersTask(UsersTask UsersTask);
        Task DeleteUsersTask(int TaskID);
        Task SaveAsync();
    }
}
