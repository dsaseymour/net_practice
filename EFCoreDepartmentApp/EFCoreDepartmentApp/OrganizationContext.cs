using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDepartmentApp
{
    class OrganizationContext : DbContext
    {
        public OrganizationContext() {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            if (!optionsBuilder.IsConfigured)
            {
                //providing our connection string
                //name of our database is EFCoreOrganization
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=EFCoreOrganization;Trusted_Connection=True;");
            }


        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
