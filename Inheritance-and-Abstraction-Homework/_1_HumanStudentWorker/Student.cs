using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_HumanStudentWorker
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.facultyNumber = value;
            }
        }
        public override string ToString()
        {
            return String.Format("First name: {0}\nLast name: {1}\nFaculty number: {2}", this.FirstName, this.LastName, this.FacultyNumber);
        }

    }
}
