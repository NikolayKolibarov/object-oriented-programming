using System;

namespace _2_EnterNumbers
{
    class Program
    {
        public static int ReadNumber(int start, int end)
        {
            while(true)
            {
                try
                {
                    string input = Console.ReadLine();
                    int number = int.Parse(input);
                    if (number < start || number > end)
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                    return number;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Number must be in range [{0}...{1}]", start, end);
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a number");
                }

            }
        }



        static void Main()
        {
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isValid = false;
                do
                {
                    try
                    {
                        int temp = ReadNumber(1, 100);
                        if (i > 0 && temp <= numbers[i - 1])
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                        numbers[i] = temp;
                        isValid = true;

                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Current number ({0}) must be bigger than the one before", numbers[i - 1]);
                    }
                } while(isValid == false);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
