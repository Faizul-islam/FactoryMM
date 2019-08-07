using FactoryMM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.CompanyPurchaseMm
{
    public class SQLCompanyPurchaseRepository : ICompanyPurchaseRepository
    {
        private readonly AppDbContext context;

        public SQLCompanyPurchaseRepository(AppDbContext context)
        {
            this.context = context;
        }

        public CompanyPurchase Add(CompanyPurchase companyPurchase)
        {
            context.CompanyPurchases.Add(companyPurchase);
            context.SaveChanges();
            return companyPurchase;
        }

        public IEnumerable<CompanyPurchase> GetAllCompanyPurchase()
        {
            return context.CompanyPurchases;
        }

        public CompanyPurchase GetCompanyPurchase(int Id)
        {
            return context.CompanyPurchases.Find(Id);
        }

        public CompanyPurchase Update(CompanyPurchase companyPurchaseChanges)
        {
            var companyper = context.CompanyPurchases.Attach(companyPurchaseChanges);
            companyper.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return companyPurchaseChanges;
        }
    }
}
