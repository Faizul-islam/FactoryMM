using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryMM.Data;
using FactoryMM.Models.CustomersOrderMm;
using FactoryMM.Models.SalesMm;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FactoryMM.Controllers
{
    public class SalesController : Controller
    {
        private AppDbContext _context;
        private ISalesRepository _salesRepository;
        private ICustomerOrderRepository _customerOrderRepository;

        public SalesController(ISalesRepository salesRepository, ICustomerOrderRepository customerOrderRepository,AppDbContext context)
        {
            _context = context;
            _salesRepository = salesRepository;
            _customerOrderRepository = customerOrderRepository;


        }

        public IActionResult Index()
        {
            var model = _salesRepository.GetAllSales();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create(int id)
        {
            var qty = _context.CustomerOrders.Find(id).Quantity;
            ViewBag.qty = qty;
           var price = _context.ProductsInventorys.Find(id).UnitPrice;

            ViewBag.unitPrice = price;
            ViewBag.Total = qty * price;

           

            ViewBag.dum = id;

            return View();
        
        }

        [HttpPost]
        public IActionResult Create(Sales model)
        {

            
            

            if (ModelState.IsValid)
            {
                Sales newSal = new Sales
                {
                    EmpId = model.EmpId,
                    CustOrderId = model.CustOrderId,
                    Total = model.Total,
                    Paid = model.Paid,
                    Due = model.Due,
                    DeliveryDate = model.DeliveryDate
                };
                _salesRepository.Add(newSal);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Sales sal = _salesRepository.GetSales(id);
            Sales salObj = new Sales
            {
                SaleId = sal.SaleId,
                EmpId = sal.EmpId,
                CustOrderId = sal.CustOrderId,
                Total = sal.Total,
                Paid = sal.Paid,
                Due = sal.Due,
                DeliveryDate = sal.DeliveryDate
            };
            return View(salObj);
        }

        [HttpPost]
        public IActionResult Edit(Sales model)
        {
            if (ModelState.IsValid)
            {
                Sales sel = _salesRepository.GetSales(model.SaleId);
                sel.EmpId = model.EmpId;
                sel.CustOrderId = model.CustOrderId;
                sel.Total = model.Total;
                sel.Paid = model.Paid;
                sel.Due = model.Due;
                sel.DeliveryDate = model.DeliveryDate;

                Sales updateProductInventory = _salesRepository.Update(sel);
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}
