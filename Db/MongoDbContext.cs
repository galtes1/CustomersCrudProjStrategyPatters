using MongoDB.Driver;
using StrategyPatters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatters.Db
{
    internal class MongoDbContext
    {
        private readonly IMongoDatabase _database;
        public MongoDbContext()
        {
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            _database = client.GetDatabase("Northwind");

        }

        public IMongoCollection<Customer> Customers => _database.GetCollection<Customer>("customers");
    }
}
