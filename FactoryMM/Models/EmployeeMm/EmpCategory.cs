using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.EmployeeMm
{
    public class EmpCategory
    {
        [Key]
        public int EmpCatId { get; set; }

        [Required]
        public string CatName { get; set; }
        public int BasicSalary { get; set; }
    }
}
