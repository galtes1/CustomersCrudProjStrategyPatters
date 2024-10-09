using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatters.Models
{
    internal interface ICrudOperations
    {
        void PrintAllCustomers();
        void PrintCustomerById(string id);
        void CreateNewCustomer(Customer customer);
        void EditCustomerById(string id, Customer newCustomer);
        void DeleteCustomerById(string id);

    }
}
