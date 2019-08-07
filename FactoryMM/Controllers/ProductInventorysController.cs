using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryMM.Models.InventoryMm.ProductInventoryMm;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FactoryMM.Controllers
{
    public class ProductInventorysController : Controller
    {
        private IProductInventoryRepository _productInventoryRepository;

        public ProductInventorysController(IProductInventoryRepository productInventoryRepository)
        {
            _productInventoryRepository = productInventoryRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = _productInventoryRepository.GetAllProductInventory();
            return View(model);
        }

         

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductInventory model)
        {
            if(ModelState.IsValid)
            {
                ProductInventory newProductInventory = new ProductInventory
                {
                    ProdInvName = model.ProdInvName,
                    Description = model.Description,
                    Quantity = model.Quantity,
                    UnitPrice = model.UnitPrice
                };
                _productInventoryRepository.Add(newProductInventory);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ProductInventory productInventory = _productInventoryRepository.GetProductInventory(id);
            ProductInventory productInventoryObj = new ProductInventory
            {
                ProdInvId = productInventory.ProdInvId,
                ProdInvName = productInventory.ProdInvName,
                Description = productInventory.Description,
                Quantity = productInventory.Quantity,
                UnitPrice = productInventory.UnitPrice
            };
            return View(productInventoryObj);
        }

        [HttpPost]
        public IActionResult Edit(ProductInventory model)
        {
            if (ModelState.IsValid)
            {
                ProductInventory productInventory = _productInventoryRepository.GetProductInventory(model.ProdInvId);
                productInventory.ProdInvName = model.ProdInvName;
                productInventory.Description = model.Description;
                productInventory.Quantity = model.Quantity;
                productInventory.UnitPrice = model.UnitPrice;

                ProductInventory updateProductInventory = _productInventoryRepository.Update(productInventory);
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}
