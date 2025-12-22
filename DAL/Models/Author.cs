using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
    }

    public class Language
    {
        public int Id { get; set; }
        public string? LanguageDesc { get; set; }

    }

    public class Books
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Category { get; set; }
        public int LanguageId { get; set; }
        public int? Authorid { get; set; }
        public Language? Language { get; set; }
        public Author? Author { get; set; }

       
    }

  
}
