using System;

class DisplayNo
{
    //1. Display numbers from 2 to 100 with a gap of 2

    public static void Main()
    {
        int n = 100;
        Console.WriteLine("the numbers are");
        for (int i = 2; i <= n; i++)
        {
            if (i % 2 == 0) 
            {
                Console.WriteLine(i);      
            }
        }
        PrintMessage();
        
    }
    public static void PrintMessage()
    {
        Console.WriteLine("Hello from Displayno!");
    }
}
