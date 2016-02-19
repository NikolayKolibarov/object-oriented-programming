using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CompanyHierarchy.Interfaces
{
    interface IProject
    {
        string Name { get; set; }

        DateTime? StartDate { get; set; }

        string Details { get; set; }

        bool State { get; set; }

        
    }
}
