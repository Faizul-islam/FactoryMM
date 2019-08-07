using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.ProductionMM
{
    public class Production
    {
        [Key]
        public int ProductionId { get; set; }

        public int ProdInvId { get; set; }

        public int MatInvId { get; set; }
    }
}
