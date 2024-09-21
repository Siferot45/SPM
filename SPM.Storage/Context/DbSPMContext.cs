using Microsoft.EntityFrameworkCore;
using SPM.Storage.Model.Entities;

namespace SPM.Storage.Context;

public class DbSPMContext : DbContext
{
    public DbSPMContext(DbContextOptions<DbSPMContext> options) : base(options)
    {
            
    }
    public DbSet<Company> Companies{ get; set; }
    public DbSet<Department> Departments{ get; set; }
    public DbSet<Employee> Employees{ get; set; }
    public DbSet<Address> Addresses{ get; set; }
}
