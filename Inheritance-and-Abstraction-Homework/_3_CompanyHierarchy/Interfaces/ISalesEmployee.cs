using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_CompanyHierarchy.Company.CompanyWorkers.RegularEmployees.SalesEmployee;

namespace _3_CompanyHierarchy.Interfaces
{
    interface ISalesEmployee : IPerson
    {
        List<Sale> Sales { get; set; }
    }
}
