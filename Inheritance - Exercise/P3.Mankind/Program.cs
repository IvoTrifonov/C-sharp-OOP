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
                Student student = StudentCreator(studentArgs);

                var workerArgs = Console.ReadLine().Split();
                Worker worker = WorkerCreator(workerArgs);

                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static Worker WorkerCreator(string[] workerArgs)
        {
            var workerFirstName = workerArgs[0];
            var workerLastName = workerArgs[1];
            var workerWeekSalary = decimal.Parse(workerArgs[2]);
            var workerWorkingHoursPerDay = decimal.Parse(workerArgs[3]);

            return new Worker(workerFirstName, workerLastName, workerWeekSalary, workerWorkingHoursPerDay);
        }

        private static Student StudentCreator(string[] studentArgs)
        {
            var studentFirstName = studentArgs[0];
            var studentLastName = studentArgs[1];
            var studentFacNumber = studentArgs[2];

            return new Student(studentFirstName, studentLastName, studentFacNumber);
        }
    }
}
