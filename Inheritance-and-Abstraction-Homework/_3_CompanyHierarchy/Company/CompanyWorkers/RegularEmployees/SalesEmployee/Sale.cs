using _3_CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CompanyHierarchy.Company.CompanyWorkers.RegularEmployees.SalesEmployee
{
    class Sale : ISale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName { get; set; }

        public DateTime Date { get; set; }

        public decimal Price { get; set; }
    }
}
