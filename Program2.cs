using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_Assingment
{
    internal class Program2
    {
        //2. Display table of 5 
       // like 5 * 1 =5
       //5 * 2 = 10

        static void Main()
        {
            int a = 5;
            int i = 1;
            for(i=1;i<=10;i++)
            {
                int b = (a * i);
                Console.WriteLine($"{a} * { i} = { b}");
            }
            

        }

        
    }

}
