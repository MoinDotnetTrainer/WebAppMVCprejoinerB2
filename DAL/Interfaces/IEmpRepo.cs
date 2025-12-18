using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IEmpRepo
    {
        // abstrct method for 

        //Insert ,update , delete , read

        Task AddEmp(Employee emp);

        // get all data

        Task<IList<Employee>> GetAllData(); // holds the data Ilist

        // get data by ID

        Task<Employee> GetDataByID(int Eid);

        //Update 
        Task UpdateEmp(Employee emp);

        Task DeleteEmp(int Eid);

    }
}
