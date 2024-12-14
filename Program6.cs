using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assingment
{
    internal class Program6
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;

            Console.WriteLine("Enter up to 10 positive integers (enter a negative number to stop):");

            while (count < 10)
            {
                Console.Write($"Enter number {count + 1}: ");
                int number;
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number < 0)
                    {
                        Console.WriteLine("Negative number entered. Stopping input.");
                        break; // Exit the loop if a negative number is entered
                    }

                    sum += number; // Add the positive number to the sum
                    count++;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }
            }

            Console.WriteLine($"The sum of the entered positive integers is: {sum}");
        }
    }
}
