using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assingment
{
    //4. Check whether a number is prime or not
    internal class Program4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check: ");
            int number = int.Parse(Console.ReadLine());

            bool isPrime = IsPrime(number);

            if (isPrime)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false; // Numbers less than or equal to 1 are not prime
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false; // If divisible by any number other than 1 and itself, it's not prime
                }
            }

            return true; // If no divisors found, it's a prime number
        }



    }
}
