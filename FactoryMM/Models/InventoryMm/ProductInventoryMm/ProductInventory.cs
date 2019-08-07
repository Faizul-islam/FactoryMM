using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.InventoryMm.ProductInventoryMm
{
    public class ProductInventory
    {
        [Key]
        public int ProdInvId { get; set; }

        [Required, MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string ProdInvName { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }

        //[Column(TypeName = "decimal(28,8)")]
        //public float Quantity { get; set; }

        //[DataType(DataType.Currency)]
        //[Column(TypeName = "money")]
        //public decimal UnitPrice { get; set; }


    }
}
