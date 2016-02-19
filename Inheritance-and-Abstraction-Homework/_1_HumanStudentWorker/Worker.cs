using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_HumanStudentWorker
{
    class Worker : Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get; set; }

        public double WorkHoursPerDay { get; set; }


        public override string ToString()
        {
            return String.Format("First name: {0}\nSecond name: {1}\nWeek salary: {2}, Work hours per day: {3}, Money per hour: {4:0.00}", this.FirstName, this.LastName, this.WeekSalary, this.WorkHoursPerDay, MoneyPerHour(this.WeekSalary, this.WorkHoursPerDay));
        }

        public decimal MoneyPerHour(decimal weekSalary, double workHoursPerDay)
        {
            // 5 Work days
            decimal moneyPerDay = weekSalary / 5;
            decimal moneyPerHour = moneyPerDay / (decimal)workHoursPerDay;
            return moneyPerHour;
        }
    }
}
