using System;

namespace Inheritance_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string title = Console.ReadLine();
                string author = Console.ReadLine();
                GoldenEditionBook bible = new GoldenEditionBook(title, author, 25);
                Console.WriteLine(bible);
            }
        }
    }
}
