using Student.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Student.DataConext
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("EfEmployee") { }

        public DbSet<Employee> Employees { get; set; }
    }
}