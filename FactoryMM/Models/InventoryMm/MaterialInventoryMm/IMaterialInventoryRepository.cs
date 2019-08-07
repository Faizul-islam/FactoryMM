using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.InventoryMm.MaterialInventoryMm
{
    public interface IMaterialInventoryRepository
    {
        MaterialInventory GetMaterialInventory(int Id);
        IEnumerable<MaterialInventory> GetAllMaterialInventory();

        MaterialInventory Add(MaterialInventory materialInventory);
        MaterialInventory Update(MaterialInventory materialInventoryChanges);
        MaterialInventory Delete(int id);
    }
}
