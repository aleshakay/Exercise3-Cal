using System;
using System.Collections.Generic;

namespace Exercise3_Cal
{
     class Program
    {
         static void Main(string[] args)
        {
            int i, n;
            int sum = 0;
            int[] a = new int[100];
            {
                if (args.Length == 0)
                {
                    Console.WriteLine("Alesha's Calculator:");
                    Console.WriteLine("*************************************************");

                    // Ask the user to choose an option.
                    Console.WriteLine("Choose an option from the following list:");
                    Console.WriteLine("\t+ - Add");
                    Console.WriteLine("\t- - Subtract");
                    Console.WriteLine("\t* - Multiply");
                    Console.WriteLine("\td - Divide");
                    Console.Write("Your option? ");

                    

                    switch (Console.ReadLine())
                    {
                        case "+":
                            for (i = 1; i <= 10; i++)
                            {
                                Console.Write("Number-{0} :", i);
                                n = Convert.ToInt32(Console.ReadLine());
                                sum += n;
                                Console.WriteLine($"Your result: {sum}");
                            }
                            break;
                        case "-":
                            for (i = 1; i <= 10; i++)
                            {
                                Console.Write("Number-{0} :", i);
                                n = Convert.ToInt32(Console.ReadLine());
                                sum -= n;
                                Console.WriteLine($"Your result: {sum}");
                            }
                            break;
                        case "*":
                            sum = 1;
                            for (i = 1; i <= 10; i++)
                            {
                                Console.Write("Number-{0} :", i);
                                n = Convert.ToInt32(Console.ReadLine());
                                sum *= n;
                                Console.WriteLine($"Your result: {sum}");
                            }
                            break;
                        case "d":
                            for (i = 1; i <= 10; i++)
                            {
                                Console.Write("Number-{0} :", i);
                                n = Convert.ToInt32(Console.ReadLine());
                                sum /= n;
                                Console.WriteLine($"Your result: {sum}");
                            }
                            break;
                    }

                }
            }
            //List<int> Numbers = new List<int>() {
            //2,4,5
            //};
            //Console.WriteLine("List: ");
            //foreach(int i in Numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //int mult = 1;
            //foreach(int i in Numbers)
            //{
            //    mult = mult * i;
            //}
            //Console.WriteLine("Total multipled numbers: {0}", mult);
        }
    }
}
