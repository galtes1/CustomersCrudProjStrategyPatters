using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPatters.Models;

namespace StrategyPatters
{
    internal class CrudManager
    {
        private ICrudOperations _crud;
        public CrudManager(ICrudOperations crudOperationsClass)
        {
            _crud = crudOperationsClass;
        }

        public void PrintAllCustomers()
        {
            _crud.PrintAllCustomers();
        }

        public void PrintCustomerById(string id)
        {
            _crud.PrintCustomerById(id);
        }

        public void CreateNewCustomer(Customer customer)
        {
            _crud.CreateNewCustomer(customer);
        }

        public void EditCustomerById(string id, Customer newCustomer)
        {
            _crud.EditCustomerById(id, newCustomer);
        }

        public void DeleteCustomerById(string id)
        {
            _crud.DeleteCustomerById(id);
        }

    }
}
