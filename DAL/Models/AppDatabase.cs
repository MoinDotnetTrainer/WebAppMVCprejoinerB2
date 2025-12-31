using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class AppDatabase : DbContext
    {
        public AppDatabase(DbContextOptions<AppDatabase> options) : base(options) { }

        // options // ur Connection string  --> data source , initial catalog
        public DbSet<Employee> employees { get; set; } // table

        public DbSet<Book> book { get; set; } // table

        public DbSet<Movies> Movies { get; set; } //
                                                  // 
        public DbSet<ValidateModel> ValidateModel { get; set; } // table
        public DbSet<User> user { get; set; } //

        public DbSet<UserProfile> UserProfile { get; set; } //

        public DbSet<Country> Country { get; set; } //

        public DbSet<State> State { get; set; } //


        public DbSet<Author> Author { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Language> Language { get; set; }

        public DbSet<City> City { get; set; }
        public DbSet<Pincode> Pincode { get; set; }

        public DbSet<Users> Users { get; set; }
        public DbSet<UsersTask> UsersTask { get; set; }
    }
}
