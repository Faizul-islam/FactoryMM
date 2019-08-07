using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.SalesMm.SalesReturnMm
{
    public class SalesReturn
    {
        [Key]
        public int SaleReturnId { get; set; }
        public int ProdInvId { get; set; }
        public int CustId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Quantity { get; set; }

        public DateTime ErturnDate { get; set; }
    }
}
