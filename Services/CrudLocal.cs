using StrategyPatters.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyPatters.Services
{
    internal class CrudLocal
    {

        static List<Customer> customers = new List<Customer>();

        public static void PrintAllCustomers()
        {
            foreach (Customer c in customers)
            {
                Console.WriteLine(c.ToString());
            }
        }

        public static void PrintCustomerById(string id)
        {
            Customer? c = customers.FirstOrDefault(c => c.CID == id);
            if (c != null)
            {
                Console.WriteLine(c.ToStringWithEnter());
            }
            else
            {
                Console.WriteLine($"Customer with ID {id} not found.");
            }

        }
        public static void CreateNewCustomer(Customer c)
        {
            customers.Add(c);
            Console.WriteLine("customer added");
        }
        public void EditCustomerById(string id, Customer newCustomer)
        {
            int indexOfCustomerToEdit = customers.FindIndex(c => c.CID == id);
            customers[indexOfCustomerToEdit] = newCustomer;
            Console.WriteLine("customer has been updated");
        }

        public static void DeleteCustomerById(string id)
        {
            Customer? CustomerToDelete = customers.FirstOrDefault(c => c.CID == id);
            customers.Remove(CustomerToDelete);
        }



    }
}
