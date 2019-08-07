using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.EmployeeMm
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                   new Employee
                   {
                       EmpId = 1,
                       EmpName = "Rahim",
                       Phone = 01755566621,
                       Address = "House#45, Road#12, Sector#10, Uttara Dhaka 1230",
                       EmpCatId = EmployeeCategor.Manager,
                       JoiningDate = DateTime.Now,
                       BloodGroup = BloodGroup.AB_Positive
                   },

                   new Employee
                   {
                       EmpId = 2,
                       EmpName = "Rahima",
                       Phone = 01755566621,
                       Address = "House#45, Road#12, Sector#10, Uttara Dhaka 1230",
                       EmpCatId = EmployeeCategor.Manager,
                       JoiningDate = DateTime.Now,
                       BloodGroup = BloodGroup.AB_Negative
                   }
               );
        }
    }
}
