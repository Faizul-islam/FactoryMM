using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryMM.Models.InventoryMm.MaterialInventoryMm;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FactoryMM.Controllers
{
    public class MaterialInventorysController : Controller
    {
        private IMaterialInventoryRepository _materialInventoryRepository;

        public MaterialInventorysController(IMaterialInventoryRepository materialInventoryRepository)
        {
            _materialInventoryRepository = materialInventoryRepository;
        }
        

        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = _materialInventoryRepository.GetAllMaterialInventory();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MaterialInventory model)
        {
            if(ModelState.IsValid)
            {
                MaterialInventory newMaterialInventory = new MaterialInventory
                {
                    MatInvName = model.MatInvName,
                    Description = model.Description,
                    Quantity = model.Quantity,
                    UnitPrice = model.UnitPrice,
                    SupId = model.SupId
                };
                _materialInventoryRepository.Add(newMaterialInventory);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            MaterialInventory materialInventory = _materialInventoryRepository.GetMaterialInventory(id);
            MaterialInventory materialInventoryObj = new MaterialInventory
            {
                MatInvId = materialInventory.MatInvId,
                MatInvName = materialInventory.MatInvName,
                Description = materialInventory.Description,
                Quantity = materialInventory.Quantity,
                UnitPrice = materialInventory.UnitPrice,
                SupId = materialInventory.SupId
            };
            return View(materialInventoryObj);
        }

        [HttpPost]
        public IActionResult Edit(MaterialInventory model)
        {
            if(ModelState.IsValid)
            {
                MaterialInventory materialInventory = _materialInventoryRepository.GetMaterialInventory(model.MatInvId);
                materialInventory.MatInvName = model.MatInvName;
                materialInventory.Description = model.Description;
                materialInventory.Quantity = model.Quantity;
                materialInventory.UnitPrice = model.UnitPrice;
                materialInventory.SupId = model.SupId;

                MaterialInventory updateMaterialInventory = _materialInventoryRepository.Update(materialInventory);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        
    }
}
