using EmployeeData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System.Xml.Linq;

namespace EmployeeData
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext()
        {

        }
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext>options) :base(options)
        {

        }
        public static bool isMigration = true;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(isMigration)
            optionsBuilder.UseSqlServer("Server=DESKTOP-HU6GJD4;Database=CompanyDbName;Trusted_Connection=True;MultipleActiveResultSets=true;User Id=sa; Password=13491a03g3");
       
        }
        public DbSet<EnsurityEmployee> Employees { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<RubixEmployees> RubixEmployeess { get; set; }


    }

}
