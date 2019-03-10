using System;

namespace P2.BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var author = Console.ReadLine();
                var title = Console.ReadLine();
                var price = decimal.Parse(Console.ReadLine());

                var book = new Book(author, title, price);
                var goldenEditionBook = new GoldenEditionBook(author, title, price);

                Console.WriteLine(book + Environment.NewLine);
                Console.WriteLine(goldenEditionBook);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
