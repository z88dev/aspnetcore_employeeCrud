using Microsoft.EntityFrameworkCore;

namespace EmployeeCrud.Models
{
    public class EmployeeCrudDbContext:DbContext
    {
        public EmployeeCrudDbContext(DbContextOptions<EmployeeCrudDbContext> options) : base(options) { 

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
