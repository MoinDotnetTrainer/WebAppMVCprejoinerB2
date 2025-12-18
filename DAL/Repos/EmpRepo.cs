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
    public class EmpRepo : IEmpRepo
    {
        public readonly AppDatabase _db;
        public EmpRepo(AppDatabase db)
        {
            _db = db;
        }

        public async Task AddEmp(Employee obj)
        {
            await _db.employees.AddAsync(obj);
            await _db.SaveChangesAsync();
        }
        public async Task<IList<Employee>> GetAllData()
        {
            return await _db.employees.ToListAsync();
        }
        public async Task<Employee> GetDataByID(int Eid)
        {
            // return await _db.employees.FirstOrDefaultAsync(x => x.Eid == Eid);
            //  return await (from s in _db.employees select s).FirstOrDefaultAsync(x => x.Eid == Eid);
            return await _db.employees.FindAsync(Eid);
        }
        public async Task UpdateEmp(Employee obj)
        {

            _db.employees.Update(obj);
            await _db.SaveChangesAsync();
        }
        public async Task DeleteEmp(int Eid)
        {
            var res = await _db.employees.FindAsync(Eid);
            if (res != null)
            {
                _db.employees.Remove(res);
                await _db.SaveChangesAsync();
            }
        }


    }
}
