﻿namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //TASK---1

            int n = 47;
            int count = 0;
            if (n == 0 || n == 1)
            {
                Console.WriteLine("ne sade, ne murekkeb");
            }
            for (int i = 2; i < n; i++)
            {
                //count += i;
                if (n % i == 0)
                {
                    count++;
                    break;
                }

            }
            if (count > 0)
            {
                Console.WriteLine("murekkeb");
            }
            else
            {
                Console.WriteLine("sade");
               
            }


            //TASK---2

            //Console.WriteLine(" Eded daxil edin:");
            //string num = Console.ReadLine();
            //int count = 0;
            //int i = 1;
            //while (i <= num.Length)
            //{

            //    count++;
            //    i++;
            //}
            //Console.WriteLine($"{count} mertebeli ededdir");
        }
    }
}
