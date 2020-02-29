using System;
using System.Collections.Generic;

namespace Exercise3_Cal
{
    public class Program
    {
        public static void Main()
        {
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
