using FactoryMM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.SupplierMm
{
    public class SQLSupplierRepository : ISupplierRepository
    {
        private readonly AppDbContext context;

        public SQLSupplierRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Supplier Add(Supplier supplier)
        {
            context.Suppliers.Add(supplier);
            context.SaveChanges();
            return supplier;

        }

        public Supplier Delete(int id)
        {
            Supplier sup = context.Suppliers.Find(id);
            if(sup != null)
            {
                context.Suppliers.Remove(sup);
                context.SaveChanges();

            }
            return sup;
        }

        public IEnumerable<Supplier> GetAllSupplier()
        {
            return context.Suppliers;
        }

        public Supplier GetSupplier(int Id)
        {
            return context.Suppliers.Find(Id);
        }

        public Supplier Update(Supplier supplierChanges)
        {
            var supupdate = context.Suppliers.Attach(supplierChanges);
            supupdate.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return supplierChanges;
        }
    }
}
