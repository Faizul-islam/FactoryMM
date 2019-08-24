using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.CustomersOrderMm
{
    public class CustomerOrder
    {
        [Key]
        public int CustOrderId { get; set; }


        public CustName? CustId { get; set; }

        public ProdName? ProdInvId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Quantity { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryTakeDate { get; set; }
    }
}
