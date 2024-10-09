using StrategyPatters.Db;
using StrategyPatters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatters.Services
{
    internal class CrudDbEntityFramework : ICrudOperations
    {
        private readonly NorthwindContext _context;

        public CrudDbEntityFramework()
        {
            _context = new NorthwindContext();
        }

        public void PrintAllCustomers()
        {
            List<Customer> customers = _context.Customers.ToList();
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.CName);
            }
        }

        public void PrintCustomerById(string id)
        {
            Customer? c = _context.Customers.FirstOrDefault(customer => customer.CID == id);
            Console.WriteLine(c);
        }

        public void CreateNewCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();

        }

        public void EditCustomerById(string id, Customer newCustomer)
        {
            Customer? custumerForEdit = _context.Customers.FirstOrDefault(customer => customer.CID == id);

            custumerForEdit.CName = newCustomer.CName;
            custumerForEdit.ContactName = newCustomer.ContactName;
            custumerForEdit.ContactTitle = newCustomer.ContactTitle;
            custumerForEdit.Address = newCustomer.Address;
            custumerForEdit.City = newCustomer.City;
            custumerForEdit.Region = newCustomer.Region;
            custumerForEdit.PostalCode = newCustomer.PostalCode;
            custumerForEdit.Country = newCustomer.Country;
            custumerForEdit.Phone = newCustomer.Phone;
            custumerForEdit.Fax = newCustomer.Fax;
            custumerForEdit.CType = newCustomer.CType;


        }

        public void DeleteCustomerById(string id)
        {

            Customer custumerForDelete = _context.Customers.FirstOrDefault(customer => customer.CID == id);
            _context.Customers.Remove(custumerForDelete);
            _context.SaveChanges();

        }




    }
}
