using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DataAccessLayer
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Software Development" },
                new Department { Id = 2, Name = "Quality Assurance and Testing" },
                new Department { Id = 3, Name = "Technical Support" }
            );
        }
    }
}
