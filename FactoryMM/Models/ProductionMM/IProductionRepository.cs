using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.ProductionMM
{
    public interface IProductionRepository
    {
        Production GetProduction(int Id);

        IEnumerable<Production> GetAllProduction();

        Production Add(Production production);

        Production Update(Production productionChanges);
    }
}
