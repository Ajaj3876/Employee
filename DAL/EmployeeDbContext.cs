using Application_Form_MVC.Models.DBEntities;
using Microsoft.EntityFrameworkCore;

namespace Application_Form_MVC.DAL
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
