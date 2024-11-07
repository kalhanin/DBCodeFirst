using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DBCodeFirst.Models;

namespace DBCodeFirst.Data
{
    public class DBCodeFirstContext : DbContext
    {
        public DBCodeFirstContext (DbContextOptions<DBCodeFirstContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "Mary", City = "Cincinnati", Age = 20, Region="South" },
                new Student { Id = 2, Name = "John", City = "Caracas", Age = 19, Region="South" }
                );
        }

        public DbSet<DBCodeFirst.Models.Student> Student { get; set; } = default!;
    }
}
