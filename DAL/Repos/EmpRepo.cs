using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class EmpRepo : IEmpRepo
    {
        public readonly AppDatabase _db;
        public EmpRepo(AppDatabase db)
        {
            _db = db;
        }

        public async Task AddEmp(Employee obj) {
            await _db.employees.AddAsync(obj);
            await _db.SaveChangesAsync();
        }
    }
}
