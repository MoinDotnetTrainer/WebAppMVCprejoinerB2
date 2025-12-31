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
     public class ITaskClass : ITaskInterface
    {
        public readonly AppDatabase _context;
        public ITaskClass(AppDatabase context) { _context = context; }

        public async Task<IEnumerable<UsersTask>> GetAllUsersTask()
        {
           // return await _context.UsersTask.ToListAsync();
            return await _context.UsersTask.Include(x => x.AssignedUser).ToListAsync();

        }

        public async Task InsertUsersTask(UsersTask UsersTask)
        {
            await _context.UsersTask.AddAsync(UsersTask);
        }


        public async Task<UsersTask?> GetUsersTaskbyID(int TaskID)
        {
            var users = await _context.UsersTask.FirstOrDefaultAsync(x => x.TaskId == TaskID);
            return users;
        }


        public async Task UpdateUsersTask(UsersTask UsersTask)
        {
            _context.UsersTask.Update(UsersTask);
        }


        public async Task DeleteUsersTask(int TaskID)
        {

            var res = await _context.UsersTask.FindAsync(TaskID);
            if (res != null)
            {
                _context.UsersTask.Remove(res);
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
