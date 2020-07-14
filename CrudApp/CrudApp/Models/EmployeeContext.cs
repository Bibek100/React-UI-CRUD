using CrudApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudApp.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
