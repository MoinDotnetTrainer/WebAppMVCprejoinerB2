using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation property
        public UserProfile UserProfile { get; set; }
    }
    public class UserProfile
    {
        public int Id { get; set; }
        public string Address { get; set; }

        // Foreign Key
        public int UserId { get; set; }

        // Navigation property
        public User User { get; set; }
    }



}
