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

    }
}
