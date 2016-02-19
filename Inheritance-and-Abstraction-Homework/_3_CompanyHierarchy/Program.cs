using _3_CompanyHierarchy.Company;
using _3_CompanyHierarchy.Company.CompanyWorkers;
using _3_CompanyHierarchy.Company.CompanyWorkers.RegularEmployees.Developer;
using _3_CompanyHierarchy.Company.CompanyWorkers.RegularEmployees.SalesEmployee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CompanyHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> pumaManagerEmployees = new List<Employee>();
            Manager pumaManager = new Manager("20a", "Joshua", "Peterson", 10000, DepartmentType.Marketing, pumaManagerEmployees);

            List<Employee> adidasManagerEmployees = new List<Employee>();
            Manager adidasManager = new Manager("50a", "Vin", "Schneider", 11000, DepartmentType.Accounting, adidasManagerEmployees);

            List<Sale> pumaSales = new List<Sale>();
            SalesEmployee pumaSalesEmployee = new SalesEmployee("25b", "John", "Snow", 2500, DepartmentType.Sales, pumaSales);

            List<Sale> adidasSales = new List<Sale>();
            SalesEmployee adidasSalesEmployee = new SalesEmployee("21b", "Jim", "Summer", 4500, DepartmentType.Sales, adidasSales);
            
            List<Project> appleProjects = new List<Project>();
            Developer appleDeveloper = new Developer("12b", "George", "Simpson", 5500, DepartmentType.Production, appleProjects);

            List<Project> sonyProjects = new List<Project>();
            Developer sonyDeveloper = new Developer("551b", "Yamamoto", "Tsuchigumo", 125500, DepartmentType.Production, sonyProjects);

            List<Employee> employees = new List<Employee>();
            employees.Add(pumaManager);
            employees.Add(adidasManager);
            employees.Add(pumaSalesEmployee);
            employees.Add(adidasSalesEmployee);
            employees.Add(appleDeveloper);
            employees.Add(sonyDeveloper);

            foreach (var employee in employees)
            {
                Console.WriteLine(employee + "\n");
            }
        }
    }
}
