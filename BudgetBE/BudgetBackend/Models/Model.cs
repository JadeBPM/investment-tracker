using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetBackend.Models;
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


}
