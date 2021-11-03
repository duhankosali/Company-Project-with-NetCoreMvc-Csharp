using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCore.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; } 
        public string EmployeeName { get; set; }    
        public string EmployeeCity { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }  

    }
}
