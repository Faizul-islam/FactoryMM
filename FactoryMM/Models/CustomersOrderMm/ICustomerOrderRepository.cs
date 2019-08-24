using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.CustomersOrderMm
{
    public interface ICustomerOrderRepository
    {
        CustomerOrder GetCustomerOrder(int Id);

        IEnumerable<CustomerOrder> GetAllCustomerOrder();

        CustomerOrder Add(CustomerOrder customerOrder);

        CustomerOrder Update(CustomerOrder customerOrderChanges);


        CustomerOrder Delete(int id);
    }
}
