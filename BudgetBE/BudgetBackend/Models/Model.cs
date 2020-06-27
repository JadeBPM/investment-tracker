using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BudgetBackend
{
    public class BudgetContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=BudgetDB;Trusted_Connection=True;");
        }
    }

    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
