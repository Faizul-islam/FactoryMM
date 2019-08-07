using FactoryMM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.InventoryMm.MaterialInventoryMm
{
    public class SQLMaterialsInventoryRepository : IMaterialInventoryRepository
    {
        private readonly AppDbContext context;

        public SQLMaterialsInventoryRepository(AppDbContext context)
        {
            this.context = context;
        }

        public MaterialInventory Add(MaterialInventory materialInventory)
        {
            context.MaterialInventorys.Add(materialInventory);
            context.SaveChanges();
            return materialInventory;
        }

        public MaterialInventory Delete(int id)
        {
            MaterialInventory material = context.MaterialInventorys.Find(id);
            if(material != null)
            {
                context.MaterialInventorys.Remove(material);
                context.SaveChanges();
            }
            return material;
        }

        public IEnumerable<MaterialInventory> GetAllMaterialInventory()
        {
            return context.MaterialInventorys;
        }

        public MaterialInventory GetMaterialInventory(int Id)
        {
            return context.MaterialInventorys.Find(Id);
        }

        public MaterialInventory Update(MaterialInventory materialInventoryChanges)
        {
            var MaterialInv = context.MaterialInventorys.Attach(materialInventoryChanges);
            MaterialInv.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return materialInventoryChanges;
        }
    }
}
