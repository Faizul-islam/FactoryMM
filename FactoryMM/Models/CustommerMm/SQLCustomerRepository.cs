using FactoryMM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.CustommerMm
{
    public class SQLCustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext context;

        public SQLCustomerRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Customer Add(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return customer;
        }

        public Customer Delete(int id)
        {
            Customer Cust = context.Customers.Find(id);
            if (Cust != null)
            {
                context.Customers.Remove(Cust);
                context.SaveChanges();
            }
            return Cust;
        }

        public IEnumerable<Customer> GetAllCustomer()
        {
            return context.Customers;
        }

        public Customer GetCustomer(int Id)
        {
            return context.Customers.Find(Id);
        }

        public Customer Update(Customer customerChanges)
        {
            var custmr = context.Customers.Attach(customerChanges);
            custmr.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return customerChanges;
        }
    }
}
