using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.SalesMm
{
    public class Sales
    {
        [Key]
        public int SaleId { get; set; }

        public EmpSalesName? EmpId { get; set; }

        public int CustOrderId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Paid { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Due { get; set; }

        public DateTime DeliveryDate { get; set; }
    }
}
