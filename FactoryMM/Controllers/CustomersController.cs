using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryMM.Models.CustommerMm;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FactoryMM.Controllers
{
    public class CustomersController : Controller
    {
        private ICustomerRepository _customerRepository;

        public CustomersController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IActionResult Index()
        {
            var model = _customerRepository.GetAllCustomer();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer model)
        {
            if (ModelState.IsValid)
            {
                Customer newCustomer = new Customer
                {
                    CustName = model.CustName,
                    Phone = model.Phone,
                    Email = model.Email,
                    OrgName = model.OrgName
                };
                _customerRepository.Add(newCustomer);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Customer cstomer = _customerRepository.GetCustomer(id);
            Customer cstomerObj = new Customer
            {
                CustId = cstomer.CustId,
                CustName = cstomer.CustName,
                Phone = cstomer.Phone,
                Email = cstomer.Email,
                OrgName = cstomer.OrgName,
                Address = cstomer.Address
            };
            return View(cstomerObj);
        }

        [HttpPost]
        public IActionResult Edit(Customer model)
        {
            if (ModelState.IsValid)
            {
                Customer cstomer = _customerRepository.GetCustomer(model.CustId);
                cstomer.CustName = model.CustName;
                cstomer.Phone = model.Phone;
                cstomer.Email = model.Email;
                cstomer.OrgName = model.OrgName;
                cstomer.Address = model.Address;

                Customer updateProductInventory = _customerRepository.Update(cstomer);
                return RedirectToAction("Index");
            }
            return View(model);
        }


    }
}
