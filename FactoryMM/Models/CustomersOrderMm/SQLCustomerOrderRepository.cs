using FactoryMM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.CustomersOrderMm
{
    public class SQLCustomerOrderRepository : ICustomerOrderRepository
    {
        private readonly AppDbContext context;

        public SQLCustomerOrderRepository(AppDbContext context)
        {
            this.context = context;
        }
        public CustomerOrder Add(CustomerOrder customerOrder)
        {
            context.CustomerOrders.Add(customerOrder);
            context.SaveChanges();
            return customerOrder;
        }

        public CustomerOrder Delete(int id)
        {
            CustomerOrder Order = context.CustomerOrders.Find(id);
            if (Order != null)
            {
                context.CustomerOrders.Remove(Order);
                context.SaveChanges();
            }
            return Order;
        }

        public IEnumerable<CustomerOrder> GetAllCustomerOrder()
        {
            return context.CustomerOrders;
        }

        public CustomerOrder GetCustomerOrder(int Id)
        {
            return context.CustomerOrders.Find(Id);
        }

        public CustomerOrder Update(CustomerOrder customerOrderChanges)
        {
            var custmr = context.CustomerOrders.Attach(customerOrderChanges);
            custmr.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return customerOrderChanges;
        }
    }
}
