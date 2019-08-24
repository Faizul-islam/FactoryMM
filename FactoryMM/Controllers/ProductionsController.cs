using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryMM.Models.InventoryMm.ProductInventoryMm;
using FactoryMM.Models.ProductionMM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FactoryMM.Controllers
{
    public class ProductionsController : Controller
    {
        private readonly IProductionRepository _productionRepository;
        private readonly IProductInventoryRepository _productInventoryRepository;

        public ProductionsController(IProductionRepository productionRepository, IProductInventoryRepository productInventoryRepository)
        {
            _productionRepository = productionRepository;
            _productInventoryRepository = productInventoryRepository;
        }

        public ViewResult Index()
        {
            var model = _productionRepository.GetAllProduction();
            return View(model);
        }

       
        [HttpGet]
        public ViewResult Create()
        {
            //ViewBag.productName = new SelectList(_productInventoryRepository.GetAllProductInventory)
            return View();
        }

        [HttpPost]
        public IActionResult Create(Production model)
        {
            if (ModelState.IsValid)
            {
                Production newProduction = new Production
                {
                    ProdInvId = model.ProdInvId,
                    ProdQuantity = model.ProdQuantity,
                    HDPE = model.HDPE,
                    LDPE = model.LDPE,
                    PP = model.PP,
                    T2OR = model.T2OR,
                    T2OB = model.T2OB,
                    T2OY = model.T2OY,
                    Thinner = model.Thinner,
                    Wastage = model.Wastage,
                    ProdHour = model.ProdHour,
                    Date = model.Date
                };
                _productionRepository.Add(newProduction);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            Production production = _productionRepository.GetProduction(id);
            Production productionObj = new Production
            {
                ProductionId = production.ProductionId,
                ProdInvId = production.ProdInvId,
                ProdQuantity = production.ProdQuantity,
                HDPE = production.HDPE,
                LDPE = production.LDPE,
                PP = production.PP,
                T2OR = production.T2OR,
                T2OB = production.T2OB,
                T2OY = production.T2OY,
                Thinner = production.Thinner,
                Wastage = production.Wastage,
                ProdHour = production.ProdHour,
                Date = production.Date
            };
            return View(productionObj);
        }

        [HttpPost]
        public IActionResult Edit(Production model)
        {
            if (ModelState.IsValid)
            {
                Production production = _productionRepository.GetProduction(model.ProductionId);
                production.ProdInvId = model.ProdInvId;
                production.ProdQuantity = model.ProdQuantity;
                production.HDPE = model.HDPE;
                production.LDPE = model.LDPE;
                production.PP = model.PP;
                production.T2OR = model.T2OR;
                production.T2OB = model.T2OB;
                production.T2OY = model.T2OY;
                production.Thinner = model.Thinner;
                production.Wastage = model.Wastage;
                production.ProdHour = model.ProdHour;
                production.Date = model.Date;

                Production updateProduction = _productionRepository.Update(production);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
