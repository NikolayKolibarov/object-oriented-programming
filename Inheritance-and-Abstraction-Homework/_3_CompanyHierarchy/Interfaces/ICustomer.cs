using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CompanyHierarchy.Interfaces
{
    interface ICustomer : IPerson
    {
        decimal NetPurchaseAmount { get; set; }
    }
}
