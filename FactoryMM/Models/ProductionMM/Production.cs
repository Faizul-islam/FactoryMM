using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.ProductionMM
{
    public class Production
    {
        [Key]
        public int ProductionId { get; set; }

        public int ProdInvId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ProdQuantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal HDPE { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal LDPE { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PP { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal T2OR { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal T2OB { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal T2OY { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Thinner { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Wastage { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ProdHour { get; set; }

        public DateTime Date { get; set; }

        //in View page quantity insart korbo r baki fild gula haid kore dibo then controller teke calculation korbo (Hide iD er moto kore korte hobe)
    }
}
