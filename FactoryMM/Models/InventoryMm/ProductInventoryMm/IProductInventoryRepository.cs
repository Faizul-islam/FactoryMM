using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.InventoryMm.ProductInventoryMm
{
    public interface IProductInventoryRepository
    {
        ProductInventory GetProductInventory(int Id);

        IEnumerable<ProductInventory> GetAllProductInventory();

        ProductInventory Add(ProductInventory productInventory);

        ProductInventory Update(ProductInventory productInventoryChanges);


        ProductInventory Delete(int id);
        
    }
}
