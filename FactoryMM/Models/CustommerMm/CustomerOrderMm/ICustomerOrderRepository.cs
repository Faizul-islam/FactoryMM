using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.Models.CustommerMm.CustomerOrderMm
{
    interface ICustomerOrderRepository
    {
        CustomerOrder GetCustomerOrder(int Id);

        IEnumerable<CustomerOrder> GetAllCustomerOrder();

        CustomerOrder Add(CustomerOrder customer);

        CustomerOrder Update(CustomerOrder CustomerOrderChanges);


        CustomerOrder Delete(int id);
    }
}
