using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assingment
{
    internal class Program5
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("Enter 10 numbers:");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Enter number {i}: ");
                int number;
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    sum += number; // Add the number to the sum
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    i--; // Retry the same iteration
                }
            }

            Console.WriteLine($"The sum of the 10 numbers is: {sum}");
        }

    }
}
