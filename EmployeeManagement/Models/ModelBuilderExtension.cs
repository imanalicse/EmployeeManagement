using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   Id = 1,
                   Name = "Iman",
                   Department = Dept.IT,
                   Email = "imanali.cse@gmail.com"
               },
                new Employee
                {
                    Id = 2,
                    Name = "Ishak",
                    Department = Dept.HR,
                    Email = "ishak@gmail.com"
                }
           );
        }
    }
}
