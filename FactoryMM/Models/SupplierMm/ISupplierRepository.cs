using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.SupplierMm
{
    public interface ISupplierRepository
    {
        Supplier GetSupplier(int Id);

        IEnumerable<Supplier> GetAllSupplier();

        Supplier Add(Supplier supplier);

        Supplier Update(Supplier supplierChanges);

        Supplier Delete(int id);
    }
}
