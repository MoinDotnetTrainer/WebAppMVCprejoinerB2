using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{

    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // One country has many states
        public ICollection<State> States { get; set; }
    }

    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Foreign key
        public int CountryId { get; set; }

        // Navigation property
        [ForeignKey("CountryId")]
        public Country Country { get; set; }
    }
}
