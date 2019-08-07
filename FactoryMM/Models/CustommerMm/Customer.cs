using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.CustommerMm
{
    public class Customer
    {
        [Key]
        public int CustId { get; set; }

        [Required, MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string CustName { get; set; }
        public int Phone { get; set; }
        public String Email { get; set; }
        public string OrgName { get; set; }
        public string Address { get; set; }
    }
}
