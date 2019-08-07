using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.CustommerMm.CustomerOrderMm
{
    public class CustomerOrder
    {
        [Key]
        public int CustOrderId { get; set; }


        public int CustId { get; set; }

        public int ProdInvId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Quantity { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryTakeDate { get; set; }
    }
}
