using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.CompanyPurchaseMm
{
    public interface ICompanyPurchaseRepository
    {
        CompanyPurchase GetCompanyPurchase(int Id);

        IEnumerable<CompanyPurchase> GetAllCompanyPurchase();

        CompanyPurchase Add(CompanyPurchase companyPurchase);

        CompanyPurchase Update(CompanyPurchase companyPurchaseChanges);


        //CompanyPurchase Delete(int id);

    }
}
