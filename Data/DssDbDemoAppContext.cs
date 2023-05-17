using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DssDbDemoApp.Models;

namespace DssDbDemoApp.Data
{
    public class DssDbDemoAppContext : DbContext
    {
        public DssDbDemoAppContext (DbContextOptions<DssDbDemoAppContext> options)
            : base(options)
        {
        }

        public DbSet<DssDbDemoApp.Models.Employee> Employees { get; set; }
        public DbSet<DssDbDemoApp.Models.Department> Departments { get; set; }
    }
}
