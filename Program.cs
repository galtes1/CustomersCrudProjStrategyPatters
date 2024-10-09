using StrategyPatters.Models;
using StrategyPatters.Services;

namespace StrategyPatters
{
    internal class Program
    {
        static void Main(string[] args)
        {


            CrudDbDisconnected crudDbDisconnected = new CrudDbDisconnected();
            CrudManager crudManager = new CrudManager(crudDbDisconnected);
            int choise = 1;
            while (choise != 0)
            {
                choise = PrintMenu();
                switch (choise)
                {
                    case 1:
                        crudManager.PrintAllCustomers();

                        break;
                    case 2:
                        Console.WriteLine("Please enter id: ");
                        string idToPrint = Console.ReadLine();
                        crudManager.PrintCustomerById(idToPrint);
                        break;
                    case 3:
                        Customer customerToCreate = GetCustomerFromUser();
                        crudManager.CreateNewCustomer(customerToCreate);
                        break;
                    case 4:
                        Customer customerToEdit = GetCustomerFromUser();
                        crudManager.EditCustomerById(customerToEdit.CID, customerToEdit);
                        break;
                    case 5:
                        Console.Write("Please enter customer id to delete: ");
                        string idToDelete = Console.ReadLine();
                        crudManager.DeleteCustomerById(idToDelete);
                        break;
                }
                Console.WriteLine("Please enter any key to continue...");
                Console.ReadLine();
            }

        }

        static int PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Please choose option");
            Console.WriteLine();
            Console.WriteLine("1. Print all customers");
            Console.WriteLine("2. Print by id");
            Console.WriteLine("3. Add new customer");
            Console.WriteLine("4. Edit customer");
            Console.WriteLine("5. Delete customer");
            Console.WriteLine("0. Exit");
            Console.WriteLine();
            Console.WriteLine("Type your choise");
            return int.Parse(Console.ReadLine());
        }

        static Customer GetCustomerFromUser()
        {
            // Create a new customer object
            Customer customer = new Customer();

            // Prompt and read values for each property
            Console.Write("Enter CustomerID: ");
            customer.CID = Console.ReadLine();

            Console.Write("Enter Customer Name: ");
            customer.CName = Console.ReadLine();

            Console.Write("Enter Contact Name: ");
            customer.ContactName = Console.ReadLine();

            Console.Write("Enter Contact Title: ");
            customer.ContactTitle = Console.ReadLine();

            Console.Write("Enter Address: ");
            customer.Address = Console.ReadLine();

            Console.Write("Enter City: ");
            customer.City = Console.ReadLine();

            Console.Write("Enter Region (optional): ");
            customer.Region = Console.ReadLine();

            Console.Write("Enter Postal Code: ");
            customer.PostalCode = Console.ReadLine();

            Console.Write("Enter Country: ");
            customer.Country = Console.ReadLine();

            Console.Write("Enter Phone number: ");
            customer.Phone = Console.ReadLine();

            Console.Write("Enter Fax number (optional): ");
            customer.Fax = Console.ReadLine();

            Console.Write("Enter Customer Type (e.g., 'R' for Regular, 'V' for VIP): ");
            customer.CType = Convert.ToChar(Console.ReadLine());

            return customer;
        }
    }
}
