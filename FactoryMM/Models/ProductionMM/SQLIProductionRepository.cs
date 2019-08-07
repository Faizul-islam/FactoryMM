using FactoryMM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.ProductionMM
{
    public class SQLIProductionRepository : IProductionRepository
    {
        private readonly AppDbContext context;

        public SQLIProductionRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Production Add(Production production)
        {
            context.Productions.Add(production);
            context.SaveChanges();
            return production;
        }

        public IEnumerable<Production> GetAllProduction()
        {
            return context.Productions;
        }

        public Production GetProduction(int Id)
        {
            return context.Productions.Find(Id);
        }

        public Production Update(Production productionChanges)
        {
            var production = context.Productions.Attach(productionChanges);
            production.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return productionChanges;
        }
    }
}
