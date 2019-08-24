using FactoryMM.Models.EmployeeMm;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.ViewModels
{
    public class EmployeeCreateViewModel
    {

        [Required, MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string EmpName { get; set; }

        [Required]
        public int Phone { get; set; }

        [Required, MaxLength(150, ErrorMessage = "Address exceed 150 characters")]
        public string Address { get; set; }

        [Required]
        public EmployeeCategor? EmpCatId { get; set; }

        public DateTime JoiningDate { get; set; }

        public BloodGroup? BloodGroup { get; set; }

        public int Increament { get; set; }

        public IFormFile Photo { get; set; }
    }
}
