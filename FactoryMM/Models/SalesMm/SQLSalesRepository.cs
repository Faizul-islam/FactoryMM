using FactoryMM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.SalesMm
{
    public class SQLSalesRepository : ISalesRepository
    {
        private readonly AppDbContext context;

        public SQLSalesRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Sales Add(Sales sales)
        {
            context.Saleses.Add(sales);
            context.SaveChanges();
            return sales;
        }

        public Sales Delete(int id)
        {
            Sales sal = context.Saleses.Find(id);
            if(sal != null)
            {
                context.Saleses.Remove(sal);
                context.SaveChanges();
            }
            return sal;

        }

        public IEnumerable<Sales> GetAllSales()
        {
            return context.Saleses;
        }

        public Sales GetSales(int Id)
        {
            return context.Saleses.Find(Id);
        }

        public Sales Update(Sales salesChanges)
        {
            var sal = context.Saleses.Attach(salesChanges);
            sal.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return salesChanges;
        }
    }
}
