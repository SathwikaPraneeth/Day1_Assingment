using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assingment
{
    internal class Program8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();

            int vowelCount = CountVowels(name);

            Console.WriteLine($"The number of vowels in the name \"{name}\" is: {vowelCount}");
        }

        static int CountVowels(string input)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";

            foreach (char c in input)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
