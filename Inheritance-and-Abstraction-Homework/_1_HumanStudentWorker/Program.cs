using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_HumanStudentWorker
{
    class Program
    {
        static void Main()
        {

            List<Student> students = new List<Student>();
            List<Worker> workers = new List<Worker>();

            // Hard coded values
            students.Add(new Student("Nikolay", "Kolibarov", "2213sd"));
            students.Add(new Student("Georgi", "Georgiev", "213sa"));
            students.Add(new Student("Ivan", "Ivanov", "7213sd"));
            students.Add(new Student("Stefan", "Stefanov", "4213sf"));
            students.Add(new Student("Rosen", "Rosev", "3213sd"));
            students.Add(new Student("Grigor", "Grigorov", "1213sd"));
            students.Add(new Student("Stamen", "Stamenov", "5213sc"));
            students.Add(new Student("Viktor", "Viktorito", "4213ad"));
            students.Add(new Student("Slav", "Slavov", "9213sd"));
            students.Add(new Student("Pesho", "Peshovski", "1213dsd"));

            workers.Add(new Worker("Nikolay", "Kolibarov", 700m, 8));
            workers.Add(new Worker("Georgi", "Georgiev", 900m, 12));
            workers.Add(new Worker("Ivan", "Ivanov", 800m, 12));
            workers.Add(new Worker("Stefan", "Stefanov", 600m, 6));
            workers.Add(new Worker("Rosen", "Rosev", 550m, 12));
            workers.Add(new Worker("Grigor", "Grigorov", 1200m, 9));
            workers.Add(new Worker("Stamen", "Stamenov", 1000m, 11));
            workers.Add(new Worker("Viktor", "Viktorito", 920m, 10));
            workers.Add(new Worker("Slav", "Slavov", 1100m, 12));
            workers.Add(new Worker("Pesho", "Peshovski", 120m, 8)); 

            // Ordering the students into an IEnumerable
            IEnumerable<Student> orderedStudents = students.OrderBy(student => student.FacultyNumber);
            // Ordering the workers into an IEnumerable
            IEnumerable<Worker> orderedWorkers = workers.OrderBy(worker => worker.MoneyPerHour(worker.WeekSalary, worker.WorkHoursPerDay));

            //Displaying the list of ordered students
            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student + "\n");
            }
            //Displaying the lis of ordered workers
            foreach (var worker in orderedWorkers)
            {
                Console.WriteLine(worker + "\n");
            }
        }
    }
}
