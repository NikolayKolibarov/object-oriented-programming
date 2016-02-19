using _3_CompanyHierarchy.Company.CompanyWorkers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CompanyHierarchy.Interfaces
{
    interface IManager : IPerson
    {
        IEnumerable<Employee> Employees { get; }
    }
}
