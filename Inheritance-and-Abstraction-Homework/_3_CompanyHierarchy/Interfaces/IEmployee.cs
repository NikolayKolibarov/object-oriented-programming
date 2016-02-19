using _3_CompanyHierarchy.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CompanyHierarchy.Interfaces
{
    interface IEmployee : IPerson
    {
        decimal Salary { get; set; }
        DepartmentType DepartmentType { get; set; }   
    }
}
