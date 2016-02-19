using System;

namespace _1_SquareRoot
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            try
            {
                int number = int.Parse(input);
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException("Can't be negative");
                }
                Console.WriteLine(Math.Sqrt(number));
            }
            catch(FormatException)
            {
                Console.WriteLine("Must be a number");
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Caught the ArgumentOutOfRange Exception");
            }
            catch(ArithmeticException)
            {
                Console.WriteLine("Invalid operation.");
            }
            finally 
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}
