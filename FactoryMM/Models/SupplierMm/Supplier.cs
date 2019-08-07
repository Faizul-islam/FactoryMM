using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.SupplierMm
{
    public class Supplier
    {
        [Key]
        public int SupId { get; set; }

        [Required, MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string SupName { get; set; }
        public int Phone { get; set; }
        public String Email { get; set; }
        public string OrgName { get; set; }
        public string Address { get; set; }
    }
}
