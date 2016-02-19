using _3_CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CompanyHierarchy.Company.CompanyWorkers.RegularEmployees.Developer
{
    class Project : IProject
    {
        private string name;
        private DateTime? startDate;
        private string details;
        private bool state;

        public Project(string name, DateTime? startDate, string details, bool state)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.Details = details;
            this.State = state;
        }

        public string Name { get; set; }

        public DateTime? StartDate { get; set; }

        public string Details { get; set; }
        
        public bool State { get; set; }

    }
}
