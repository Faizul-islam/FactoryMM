using FactoryMM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.ReturnSels
{
    public class SQLReturnSelseRepository : IReturnSelseRepository
    {
        private readonly AppDbContext context;

        public SQLReturnSelseRepository(AppDbContext context)
        {
            this.context = context;
        }

        public ReturnSelse Add(ReturnSelse sales)
        {
            context.ReturnSelses.Add(sales);
            context.SaveChanges();
            return sales;
        }

        public ReturnSelse Delete(int id)
        {
            ReturnSelse sal = context.ReturnSelses.Find(id);
            if (sal != null)
            {
                context.ReturnSelses.Remove(sal);
                context.SaveChanges();
            }
            return sal;
        }

        public IEnumerable<ReturnSelse> GetAllReturnSelse()
        {
            return context.ReturnSelses;
        }

        public ReturnSelse GetReturnSelse(int Id)
        {
            return context.ReturnSelses.Find();
        }

        public ReturnSelse Update(ReturnSelse ReturnSelseChanges)
        {
            var sal = context.ReturnSelses.Attach(ReturnSelseChanges);
            sal.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return ReturnSelseChanges;
        }
    }
}
