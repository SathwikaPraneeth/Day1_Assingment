using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assingment
{
    internal class Program7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a full name: ");
            string fullName = Console.ReadLine();

            // Split the name into an array based on spaces
            string[] nameParts = fullName.Split(' ');

            Console.WriteLine("The name split into parts is:");
            foreach (string part in nameParts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
