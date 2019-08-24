using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryMM.Models.ReturnSels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FactoryMM.Controllers
{
    public class SalesReturnsController : Controller
    {
        private IReturnSelseRepository _salesReturnRepository;

        public SalesReturnsController(IReturnSelseRepository salesReturnRepository)
        {
            _salesReturnRepository = salesReturnRepository;
        }

        public IActionResult Index()
        {
            var model = _salesReturnRepository.GetAllReturnSelse();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ReturnSelse model)
        {
            if (ModelState.IsValid)
            {
                ReturnSelse newSalRet = new ReturnSelse
                {
                    ProdInvId = model.ProdInvId,
                    CustId = model.CustId,
                    Quantity = model.Quantity,
                    ErturnDate = model.ErturnDate
                };
                _salesReturnRepository.Add(newSalRet);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ReturnSelse saleRet = _salesReturnRepository.GetReturnSelse(id);
            ReturnSelse saleRetObj = new ReturnSelse
            {
                SaleReturnId = saleRet.SaleReturnId,
                ProdInvId = saleRet.ProdInvId,
                CustId = saleRet.CustId,
                Quantity = saleRet.Quantity,
                ErturnDate = saleRet.ErturnDate
            };
            return View(saleRetObj);
        }

        [HttpPost]
        public IActionResult Edit(ReturnSelse model)
        {
            if (ModelState.IsValid)
            {
                ReturnSelse selRet = _salesReturnRepository.GetReturnSelse(model.SaleReturnId);
                
                selRet.ProdInvId = model.ProdInvId;
                selRet.CustId = model.CustId;
                selRet.Quantity = model.Quantity;
                selRet.ErturnDate = model.ErturnDate;

                ReturnSelse updateProductInventory = _salesReturnRepository.Update(selRet);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
