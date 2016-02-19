using _3_CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CompanyHierarchy.Company.CompanyWorkers
{
    class Manager : Employee, IManager
    {
        private List<Employee> employees;

        public Manager(string id, string firstName, string lastName, decimal salary, DepartmentType department, List<Employee> employees)
            : base(id, firstName, lastName, salary, department)
        {
            this.employees = new List<Employee>();
        }

        public IEnumerable<Employee> Employees { get { return this.employees; } }

        public override string ToString()
        {
            return String.Format("ID: {0}\nFirst name: {1}\nLast name: {2}\nSalary: {3}\nDepartment: {4}", this.Id, this.FirstName, this.LastName, this.Salary, this.DepartmentType);
        }

        public void AddEmployee(Employee employee)
        {
            if (employee.DepartmentType != this.DepartmentType)
            {
                throw new ArgumentException("Employee and manager should be of the same department type");
            }
            this.employees.Add(employee);
        }
    }
}
