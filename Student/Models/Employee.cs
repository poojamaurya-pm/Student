using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Student.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public Nullable<decimal> EmployeeSalary { get; set; }
        public string EmployeeCity { get; set; }
    }
}