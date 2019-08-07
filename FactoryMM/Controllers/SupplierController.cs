using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryMM.Models.SupplierMm;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FactoryMM.Controllers
{
    public class SupplierController : Controller
    {
        private ISupplierRepository _supplierRepository;

        public SupplierController(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public IActionResult Index()
        {
            var model = _supplierRepository.GetAllSupplier();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Supplier model)
        {
            if (ModelState.IsValid)
            {
                Supplier newSup = new Supplier
                {
                    SupName = model.SupName,
                    Phone = model.Phone,
                    Email = model.Email,
                    OrgName = model.OrgName,
                    Address = model.Address
                };
                _supplierRepository.Add(newSup);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Supplier cstomer = _supplierRepository.GetSupplier(id);
            Supplier cstomerObj = new Supplier
            {
                SupId = cstomer.SupId,
                SupName = cstomer.SupName,
                Phone = cstomer.Phone,
                Email = cstomer.Email,
                OrgName = cstomer.OrgName,
                Address = cstomer.Address
            };
            return View(cstomerObj);
        }

        [HttpPost]
        public IActionResult Edit(Supplier model)
        {
            if (ModelState.IsValid)
            {
                Supplier sup = _supplierRepository.GetSupplier(model.SupId);
                sup.SupName = model.SupName;
                sup.Phone = model.Phone;
                sup.Email = model.Email;
                sup.OrgName = model.OrgName;
                sup.Address = model.Address;

                Supplier updateProductInventory = _supplierRepository.Update(sup);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
