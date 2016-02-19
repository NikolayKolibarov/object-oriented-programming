using _3_CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CompanyHierarchy.Company
{
    class Customer : Person, ICustomer
    {
        private decimal netPurchaseAmount;

        public Customer(string id, string firstName, string lastName, decimal netPurchaseAmount)
            : base(id, firstName, lastName)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount { get; set; }

        public override string ToString()
        {
            return String.Format("ID: {0}\nFirst name: {1}\nLast name: {2}", this.Id, this.FirstName, this.LastName);
        }
    }
}
