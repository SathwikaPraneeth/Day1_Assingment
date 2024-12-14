using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assingment
{
    internal class Program3
    {
        // Take a character and check its vowel, consonant, integer or special character
        static void Main()
        {
           Console.WriteLine("enter a character");
            char input =Console.ReadKey().KeyChar;

            if ("aeiouAEIOU".Contains(input))
            {
                Console.WriteLine("The character is a vowel");

            }
            else if (Char.IsLetter(input))//consonant
            {
                Console.WriteLine("\nThe character is a consonant.");
            }
            else if (Char.IsDigit(input))//digit
            {
                Console.WriteLine("\nThe character is an integer.");
            }
            else
            {
                Console.WriteLine("\nThe character is a special character.");
            }
            Console.Read();
        }
    }
}
