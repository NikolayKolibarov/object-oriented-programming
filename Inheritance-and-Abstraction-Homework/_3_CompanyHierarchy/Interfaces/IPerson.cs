using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CompanyHierarchy.Interfaces
{
    interface IPerson
    {
        string Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}
