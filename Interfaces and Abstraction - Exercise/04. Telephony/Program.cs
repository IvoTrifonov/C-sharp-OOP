using System;

namespace P4.Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split();
            var urls = Console.ReadLine().Split();

            var smartphone = new SmartPhone();

            Console.WriteLine(smartphone.Call(numbers));
            Console.WriteLine(smartphone.Browse(urls));

        }
    }
}
