using System;

namespace P3.Mankind
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var studentArgs = Console.ReadLine().Split();
                var studentFirstName = studentArgs[0];
                var studentLastName = studentArgs[1];
                var studentFacNumber = studentArgs[2];
                var student = new Student(studentFirstName, studentLastName, studentFacNumber);

                var workerArgs = Console.ReadLine().Split();
                var workerFirstName = workerArgs[0];
                var workerLastName = workerArgs[1];
                var workerWeekSalary = decimal.Parse(workerArgs[2]);
                var workerWorkingHoursPerDay = decimal.Parse(workerArgs[3]);
                var worker = new Worker(workerFirstName, workerLastName, workerWeekSalary, workerWorkingHoursPerDay);

                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
