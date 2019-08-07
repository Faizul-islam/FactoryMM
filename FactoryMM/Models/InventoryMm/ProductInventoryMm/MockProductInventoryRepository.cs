using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.InventoryMm.ProductInventoryMm
{
    public class MockProductInventoryRepository : IProductInventoryRepository
    {
        private List<ProductInventory> _productInventoryList;
        public MockProductInventoryRepository()
        {
            _productInventoryList = new List<ProductInventory>()
            {
                new ProductInventory(){ProdInvId=1, ProdInvName= "New st Product Enventory", Description= "This is th new Enventory", Quantity= 25.3m, UnitPrice= 58.8m},
                new ProductInventory(){ProdInvId=2, ProdInvName= "New nd Product Enventory", Description= "This is th new Enventory", Quantity= 5, UnitPrice= 685}
            };
        }

        public ProductInventory Add(ProductInventory productInventory)
        {
            productInventory.ProdInvId = _productInventoryList.Max(p => p.ProdInvId) + 1;
            _productInventoryList.Add(productInventory);
            return productInventory;
        }

        public ProductInventory Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductInventory> GetAllProductInventory()
        {
            return _productInventoryList;
        }

        public ProductInventory GetProductInventory(int id)
        {
            return this._productInventoryList.FirstOrDefault(p => p.ProdInvId == id);
        }

        public ProductInventory Update(ProductInventory productInventoryChanges)
        {
            ProductInventory productInventory = _productInventoryList.FirstOrDefault(p => p.ProdInvId == productInventoryChanges.ProdInvId);
            if(productInventory != null)
            {
                productInventory.ProdInvName = productInventoryChanges.ProdInvName;
                productInventory.Description = productInventoryChanges.Description;
                productInventory.Quantity = productInventoryChanges.Quantity;
                productInventory.UnitPrice = productInventoryChanges.UnitPrice;

            }
            return productInventory;
        }
    }
}
