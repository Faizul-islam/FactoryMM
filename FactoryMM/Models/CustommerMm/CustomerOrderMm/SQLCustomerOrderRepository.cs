using FactoryMM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.CustommerMm.CustomerOrderMm
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
            CustomerOrder CustOrder = context.CustomerOrders.Find(id);
            if (CustOrder != null)
            {
                context.CustomerOrders.Remove(CustOrder);
                context.SaveChanges();
            }
            return CustOrder;
        }

        public IEnumerable<CustomerOrder> GetAllCustomerOrder()
        {
            return context.CustomerOrders;
        }

        public CustomerOrder GetCustomerOrder(int Id)
        {
            return context.CustomerOrders.Find(Id);
        }

        public CustomerOrder Update(CustomerOrder CustomerOrderChanges)
        {
            var custmrOrder = context.CustomerOrders.Attach(CustomerOrderChanges);
            custmrOrder.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return CustomerOrderChanges;
        }
    }
}
