using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
   

    public interface IBookRepo
    {
        // abstrct method for 

        //Insert ,update , delete , read

        Task AddBook(Book book);

        // get all data

        Task<IList<Book>> GetAllBooks(); // holds the data Ilist

        // get data by ID

        Task<Book> GetDataBookByID(int BookD);

        //Update 
        Task UpdateBook(Book emp);

        Task DeleteBook(int BookID);

    }
}
