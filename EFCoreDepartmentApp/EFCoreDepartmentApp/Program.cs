using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreDepartmentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OrganizationContext Ocx = new OrganizationContext();
            var DepartmentVar = new Department()
            {
                Name="Dev",
                Description="Development"
            };
            Ocx.Departments.Add(DepartmentVar);
            Ocx.SaveChanges();

            List<Department> DepartmentList = Ocx.Departments.ToList();
             



        }
    }
}
