using FactoryMM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.InventoryMm.ProductInventoryMm
{
    public class SQLProductionInventoryRepository : IProductInventoryRepository
    {
        private readonly AppDbContext context;

        public SQLProductionInventoryRepository(AppDbContext context)
        {
            this.context = context;
        }

        public ProductInventory Add(ProductInventory productInventory)
        {
            context.ProductsInventorys.Add(productInventory);
            context.SaveChanges();
            return productInventory;
        }

        public ProductInventory Delete(int id)
        {
            ProductInventory product = context.ProductsInventorys.Find(id);
            if(product != null)
            {
                context.ProductsInventorys.Remove(product);
                context.SaveChanges();
            }
            return product;
        }

        public IEnumerable<ProductInventory> GetAllProductInventory()
        {
            return context.ProductsInventorys;
        }

        public ProductInventory GetProductInventory(int Id)
        {
            return context.ProductsInventorys.Find(Id);
        }

        public ProductInventory Update(ProductInventory productInventoryChanges)
        {
            var productionInv = context.ProductsInventorys.Attach(productInventoryChanges);
            productionInv.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return productInventoryChanges;
        }
    }
}
