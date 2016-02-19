using _3_CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CompanyHierarchy.Company.CompanyWorkers.RegularEmployees.SalesEmployee
{
    class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private List<Sale> sales;

        public SalesEmployee(string id, string firstName, string lastName, decimal salary, DepartmentType department, List<Sale> sales)
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
        }

        public List<Sale> Sales { get; set; }

        public override string ToString()
        {
            return String.Format("ID: {0}\nFirst name: {1}\nLast name: {2}\nSalary: {3}\nDepartment: {4}", this.Id, this.FirstName, this.LastName, this.Salary, this.DepartmentType);
        }
    }
}
