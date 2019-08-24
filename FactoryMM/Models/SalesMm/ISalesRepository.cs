using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.SalesMm
{
    public interface ISalesRepository
    {
        Sales GetSales(int Id);

        IEnumerable<Sales> GetAllSales();

        Sales Add(Sales sales);

        Sales Update(Sales salesChanges);


        Sales Delete(int id);
    }
}
