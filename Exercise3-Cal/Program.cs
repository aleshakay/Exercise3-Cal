using System;
using System.Collections.Generic;

namespace Exercise3_Cal
{
     class Program
    {
         static void Main(string[] args)
        {
            //{
            //    if (args.Length == 0)
            //    {
            //        Console.WriteLine("Would you like to multiply or square.");
            //        string mathOperation = Console.ReadLine();
            //        Console.WriteLine("Enter a list of numbers:") 
            //    }

            //}
            List<int> Numbers = new List<int>() {
            2,4,5
            };
            Console.WriteLine("List: ");
            foreach(int i in Numbers)
            {
                Console.WriteLine(i);
            }
            int mult = 1;
            foreach(int i in Numbers)
            {
                mult = mult * i;
            }
            Console.WriteLine("Total multipled numbers: {0}", mult);
        }
    }
}
