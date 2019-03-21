using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreDepartmentApp
{
    class Department
    {   [Key]    
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

     }
}
