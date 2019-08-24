using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Providers.Entities;
using FactoryMM.Data;
using FactoryMM.Models.CustomersOrderMm;
using FactoryMM.Models.CustommerMm;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FactoryMM.Controllers
{
    public class CustOrderController : Controller
    {
        private ICustomerOrderRepository _customerOrderRepository;
        private AppDbContext _contex;

        public CustOrderController(ICustomerOrderRepository customerOrderRepository, AppDbContext contex)
        {
            _customerOrderRepository = customerOrderRepository;
            _contex = contex;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = _customerOrderRepository.GetAllCustomerOrder();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<Customer> custNames = new List<Customer>();

            custNames = _contex.Customers.ToList();
            custNames.Insert(0, new Customer { CustId = 0, CustName = "Select" });
            ViewBag.Customer = custNames;
            return View();
        }

        [HttpPost]
        public IActionResult Create(CustomerOrder model)
        {
            if (ModelState.IsValid)
            {
                CustomerOrder newCustomerOrder = new CustomerOrder
                {
                    CustId = model.CustId,
                    ProdInvId = model.ProdInvId,
                    Quantity = model.Quantity,
                    OrderDate = model.OrderDate,
                    DeliveryTakeDate = model.DeliveryTakeDate
                };

                HttpContext.Session.SetString("Test", model.Quantity.ToString());
                _customerOrderRepository.Add(newCustomerOrder);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            CustomerOrder cstomer = _customerOrderRepository.GetCustomerOrder(id);
            CustomerOrder cstomerObj = new CustomerOrder
            {
                CustOrderId = cstomer.CustOrderId,
                CustId = cstomer.CustId,
                ProdInvId = cstomer.ProdInvId,
                Quantity = cstomer.Quantity,
                OrderDate = cstomer.OrderDate,
                DeliveryTakeDate = cstomer.DeliveryTakeDate
            };
            return View(cstomerObj);
        }

        [HttpPost]
        public IActionResult Edit(CustomerOrder model)
        {
            if (ModelState.IsValid)
            {
                CustomerOrder cstomerOrder = _customerOrderRepository.GetCustomerOrder(model.CustOrderId);
                cstomerOrder.CustId = model.CustId;
                cstomerOrder.ProdInvId = model.ProdInvId;
                cstomerOrder.Quantity = model.Quantity;
                cstomerOrder.OrderDate = model.OrderDate;
                cstomerOrder.DeliveryTakeDate = model.DeliveryTakeDate;

                CustomerOrder updateProductInventory = _customerOrderRepository.Update(cstomerOrder);
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}
