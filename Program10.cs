using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assingment
{
    internal class Program10
    {
        static void Main(String[] args)
        {
            DisplayNo.PrintMessage();
            Console.WriteLine("enter num ");
           int num = Convert.ToInt32(Console.ReadLine());
            Display(num);

        }

         public static int Display(int num)
              {
            
            for (int i = 0; i <= num; i++)
            { 
                Console.WriteLine(i);
            }
            return num;
          }
    }
}
