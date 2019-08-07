using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryMM.Models.CompanyPurchaseMm;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FactoryMM.Controllers
{
    public class CompanyPurchasesController : Controller
    {
        private ICompanyPurchaseRepository _companyPurchaseRepository;

        public CompanyPurchasesController(ICompanyPurchaseRepository companyPurchaseRepository)
        {
            _companyPurchaseRepository = companyPurchaseRepository;
        }

        public IActionResult Index()
        {
            var model = _companyPurchaseRepository.GetAllCompanyPurchase();
            return View(model);
        }



        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CompanyPurchase model)
        {
            if (ModelState.IsValid)
            {
                CompanyPurchase newCompanyPurchase = new CompanyPurchase
                {
                    MatInvId = model.MatInvId,
                    Quantity = model.Quantity,
                    Total = model.Total,
                    Paid = model.Paid,
                    Due = model.Due,
                    PurchaseDate = model.PurchaseDate
                };
                _companyPurchaseRepository.Add(newCompanyPurchase);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            CompanyPurchase companyPurchase = _companyPurchaseRepository.GetCompanyPurchase(id);
            CompanyPurchase companyPurchaseObj = new CompanyPurchase
            {
                PurchaseId = companyPurchase.PurchaseId,
                MatInvId = companyPurchase.MatInvId,
                Quantity = companyPurchase.Quantity,
                Total = companyPurchase.Total,
                Paid = companyPurchase.Paid,
                Due = companyPurchase.Due,
                PurchaseDate = companyPurchase.PurchaseDate
            };
            return View(companyPurchaseObj);
        }

        [HttpPost]
        public IActionResult Edit(CompanyPurchase model)
        {
            if (ModelState.IsValid)
            {
                CompanyPurchase companyPurchase = _companyPurchaseRepository.GetCompanyPurchase(model.PurchaseId);
                companyPurchase.MatInvId = model.MatInvId;
                companyPurchase.Quantity = model.Quantity;
                companyPurchase.Total = model.Total;
                companyPurchase.Paid = model.Paid;
                companyPurchase.Due = model.Due;
                companyPurchase.PurchaseDate = model.PurchaseDate;

                CompanyPurchase updateCompanyPurchase = _companyPurchaseRepository.Update(companyPurchase);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
