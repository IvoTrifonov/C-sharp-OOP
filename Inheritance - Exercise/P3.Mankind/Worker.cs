using System;
using System.Text;

namespace P3.Mankind
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get => this.weekSalary;

            protected set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get => this.workHoursPerDay;

            protected set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal GetSalaryPerHour()
        {
            var daySalary = this.WeekSalary / 5;
            return daySalary / WorkHoursPerDay;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"First Name: {this.FirstName}");
            sb.AppendLine($"Last Name: {this.LastName}");
            sb.AppendLine($"Week Salary: {this.WeekSalary:f2}");
            sb.AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}");
            sb.Append($"Salary per hour: {this.GetSalaryPerHour():f2}");

            return sb.ToString().Trim();
        }
    }
}
