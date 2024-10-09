using System.ComponentModel.DataAnnotations;

namespace StrategyPatters.Models
{
    public class Customer
    {
        [Key]
        public string CID { get; set; }
        public string? CName { get; set; }
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public char? CType { get; set; }

        public Customer(string cID, string cName, string contactName, string contactTitle, string address, string city, string region, string postalCode, string country, string phone, string fax, char cType)
        {
            CID = cID;
            CName = cName;
            ContactName = contactName;
            ContactTitle = contactTitle;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
            Phone = phone;
            Fax = fax;
            CType = cType;
        }

        public Customer() { }

        public string ToStringWithEnter()
        {
            return
               $"Customer ID: {CID}\n" +
               $"Customer Name: {CName}\n" +
               $"Contact Name: {ContactName}\n" +
               $"Contact Title: {ContactTitle}\n" +
               $"Address: {Address}\n" +
               $"City: {City}\n" +
               $"Region: {Region}\n" +
               $"Postal Code: {PostalCode}\n" +
               $"Country: {Country}\n" +
               $"Phone: {Phone}\n" +
               $"Fax: {Fax}\n" +
               $"Customer Type: {CType}";
        }
        public override string ToString()
        {
            return $"ID:{CID}, Name:{CName}, ContactName{ContactName}, ContactTitle:{ContactTitle}, Address:{Address}, City:{City}, Region:{Region}, PostalCode:{PostalCode}, Country{Country}, Phone:{Phone}, Fax:{Fax}, CustomerType{CType}";
        }
    }

}

