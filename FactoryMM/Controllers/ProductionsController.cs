using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryMM.Models.ProductionMM;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FactoryMM.Controllers
{
    public class ProductionsController : Controller
    {
        private readonly IProductionRepository _productionRepository;

        public ProductionsController(IProductionRepository productionRepository)
        {
            _productionRepository = productionRepository;
        }

        public ViewResult Index()
        {
            var model = _productionRepository.GetAllProduction();
            return View(model);
        }

       
        [HttpGet]
        public ViewResult Create()
        {
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
                    MatInvId = model.MatInvId
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
                MatInvId = production.MatInvId
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
                production.MatInvId = model.MatInvId;

                Production updateProduction = _productionRepository.Update(production);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
