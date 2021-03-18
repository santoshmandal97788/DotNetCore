﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   Id = 1,
                   Name = "Mark",
                   Department = Dept.IT,
                   Email = "mark@gmail.com"

               },
               new Employee
               {
                   Id = 2,
                   Name = "Sam",
                   Department = Dept.HR,
                   Email = "sam@gmail.com"

               }
               );
        }
    }
    
}
