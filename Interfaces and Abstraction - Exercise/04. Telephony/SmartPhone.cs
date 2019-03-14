using System;
using System.Linq;
using System.Text;

namespace P4.Telephony
{
    public class SmartPhone : ICallable, IBrowsable
    {
        public string Browse(string[] urls)
        {
            var sb = new StringBuilder();

            foreach (var url in urls)
            {
                if (!url.Any(c => char.IsDigit(c)))
                {
                    sb.AppendLine($"Browsing: {url}!");
                }
                else
                {
                    sb.AppendLine($"Invalid URL!");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public string Call(string[] numbers)
        {
            var sb = new StringBuilder();

            foreach (var number in numbers)
            {
                if (number.All(c => char.IsDigit(c)))
                {
                    sb.AppendLine($"Calling... {number}");
                }
                else
                {
                    sb.AppendLine($"Invalid number!");
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
