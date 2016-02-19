using _3_CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CompanyHierarchy.Company.CompanyWorkers.RegularEmployees
{
    class RegularEmployee : Employee, IRegularEmployee
    {
        public RegularEmployee(string id, string firstName, string lastName, decimal salary, DepartmentType departmentType)
            : base(id, firstName, lastName, salary, departmentType)
        {

        }
    }
}
