using System;
using System.IO;

namespace Lab3Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, what is your name? ");
            string name = Console.ReadLine();
            do
            {
                byte input = 0;
                bool valid = false;
                while (!valid)
                {
                    Console.Write("Please enter a number between 1 and 100: ");
                    try
                    {
                        input = byte.Parse(Console.ReadLine()); //byte can only be positive, so this will jump to the catch block on negative numbers, numbers over 255, and anything that isn't a number

                        if (input > 100 || input == 0)
                            throw new InvalidDataException(); //jump to the catch block if the input is 101-255

                        valid = true;
                    }
                    catch
                    {
                        Console.WriteLine("Input was not valid, please try again.");
                    }
                }

                Console.WriteLine($"Thank you for your input of {input}, {name}.");

                Console.Write("Your input was ");
                if (input % 2 == 1) // the number is odd
                {
                    Console.WriteLine($"{input} and Odd");
                }
                else // the number is even
                {
                    if (input > 60)
                        Console.Write($"{input} ");
                    Console.Write("Even");
                    if (input < 25)
                        Console.Write(" and less than 25");

                    Console.WriteLine();
                }

                Console.Write("Enter y(es) to continue or anything else to exit: ");

            } while (Console.ReadLine().ToLower().StartsWith('y'));
        }
    }
}
