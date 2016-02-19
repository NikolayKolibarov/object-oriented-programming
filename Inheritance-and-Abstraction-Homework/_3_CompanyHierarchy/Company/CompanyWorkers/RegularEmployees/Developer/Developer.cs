using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_CompanyHierarchy.Interfaces;

namespace _3_CompanyHierarchy.Company.CompanyWorkers.RegularEmployees.Developer
{
    class Developer : RegularEmployee, IDeveloper
    {
        private List<Project> projects;

        public Developer(string id, string firstName, string lastName, decimal salary, DepartmentType department, List<Project> projects)
            : base(id, firstName, lastName, salary, department)
        {
            this.Projects = projects;
        }

        public List<Project> Projects { get; set; }

        public override string ToString()
        {
            return String.Format("ID: {0}\nFirst name: {1}\nLast name: {2}\nSalary: {3}\nDepartment: {4}", this.Id, this.FirstName, this.LastName, this.Salary, this.DepartmentType);
        }

        public void CloseProject(Project project)
        {
            bool containsProject = this.Projects.Any(pr => pr == project);

            if (!containsProject)
            {
                throw new ArgumentException("Project isn't part this Developer's project");
            }

            project.State = false;
        }
    }
}
