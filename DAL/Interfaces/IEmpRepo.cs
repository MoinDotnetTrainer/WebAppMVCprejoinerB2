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
    }
}
