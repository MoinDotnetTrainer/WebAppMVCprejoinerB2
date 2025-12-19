using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Table("tbl_Movies")]
    public class Movies
    {
        [Key]
        public int MovieID { get; set; }

        [Required(ErrorMessage ="Movie Name Required")]  // no null will be accepted
        public string MovieName { get; set; }   // mandtory  // no null , value needed


        [Required(ErrorMessage ="Date Required")]
        public DateTime ReleaseDate { get; set; }  // no null , value needed
    }
}
