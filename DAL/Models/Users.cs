using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "UserName Required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Email Required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password Required")]
        public string? Password { get; set; }
        public List<UsersTask>? AssignedTasks { get; set; }
    }
    public class UsersTask
    {
        [Key]
        public int TaskId { get; set; }

        [Required(ErrorMessage = "Title Required")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Description Required")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "DueDate Required")]
        public DateTime DueDate { get; set; }

        [Required(ErrorMessage = "Status Required")]
        public string? Status { get; set; }

        [Required(ErrorMessage = "AssignedUserId Required")]
        public int AssignedUserId { get; set; }// userid will be given , to a specif user this task is assigned
        public Users? AssignedUser { get; set; } // navigation to user info
    }
}
