using MongoDB.Driver;
using StrategyPatters.Db;
using StrategyPatters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatters.Services
{
    internal class CrudDbMongoDb : ICrudOperations

    {
        private readonly MongoDbContext _mongoDbContext;

        public CrudDbMongoDb()
        {
            _mongoDbContext = new MongoDbContext();
        }

        public void PrintAllCustomers()
        {
            List<Customer> customers = _mongoDbContext.Customers.Find(c => true).ToList();
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer);
            }
        }

        public void PrintCustomerById(string id)
        {
            Customer? c = _mongoDbContext.Customers.Find(c => c.CID == id).FirstOrDefault();
            Console.WriteLine(c);
        }

        public void CreateNewCustomer(Customer c)
        {
            _mongoDbContext.Customers.InsertOne(c);
        }

        public void EditCustomerById(string id, Customer newCustomer)
        {
            var filter = Builders<Customer>.Filter.Eq(customer => customer.CID, id);

            var update = Builders<Customer>.Update
                .Set(customer => customer.CName, newCustomer.CName)
                .Set(customer => customer.ContactName, newCustomer.ContactName)
                .Set(customer => customer.ContactTitle, newCustomer.ContactTitle)
                .Set(customer => customer.Address, newCustomer.Address)
                .Set(customer => customer.City, newCustomer.City)
                .Set(customer => customer.Region, newCustomer.Region)
                .Set(customer => customer.PostalCode, newCustomer.PostalCode)
                .Set(customer => customer.Country, newCustomer.Country)
                .Set(customer => customer.Phone, newCustomer.Phone)
                .Set(customer => customer.Fax, newCustomer.Fax)
                .Set(customer => customer.CType, newCustomer.CType);

            var result = _mongoDbContext.Customers.UpdateOne(filter, update);

            Console.WriteLine("Customer updated successfully.");
        }

        public void DeleteCustomerById(string id)
        {
            _mongoDbContext.Customers.DeleteOne(c => c.CID == id);
        }
    }
}
