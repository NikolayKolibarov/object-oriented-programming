using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_CompanyHierarchy.Company.CompanyWorkers.RegularEmployees.Developer;

namespace _3_CompanyHierarchy.Interfaces
{
    interface IDeveloper : IPerson
    {
        List<Project> Projects { get; set; }
    }
}
