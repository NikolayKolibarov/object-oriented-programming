using _3_CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CompanyHierarchy.Company.CompanyWorkers
{
    class Employee : Person, IEmployee
    {
        private decimal salary;

        public Employee(string id, string firstName, string lastName, decimal salary, DepartmentType departmentType)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.DepartmentType = departmentType;
        }

        public DepartmentType DepartmentType { get; set; }

        public decimal Salary { get; set; }

        public override string ToString()
        {
            return String.Format("ID: {0}\nFirst name: {1}\nLast name: {2}\nSalary: {3}\nDepartment: {4}", this.Id, this.FirstName, this.LastName, this.Salary, this.DepartmentType);
        }
    }
}
