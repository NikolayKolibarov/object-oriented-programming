using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_CompanyHierarchy.Interfaces;

namespace _3_CompanyHierarchy
{
    public abstract class Person : IPerson
    {
        protected string id;
        protected string firstName;
        protected string lastName;

        public Person(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
