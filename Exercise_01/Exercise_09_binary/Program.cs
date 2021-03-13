using System;
using System.Collections.Generic;

namespace Exercise_09_binary
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 439;
            int count = 0;

            while(n > 0)
            {
                n = (n & (n << 1));
                count++;
            }
            Console.WriteLine(count);
            //List<int> binary = new List<int>();

            //int remainder = 0;

            //while(n >= 1)
            //{
            //    remainder = n % 2;
            //    n = n / 2;
            //    binary.Add(remainder);
            //}
            //int sum = 0;
            //foreach (var item in binary)
            //{
            //    if (item == 1)
            //    {

            //        sum++;
            //    }
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i < binary.Count; i++)
            //{
            //    if (binary[i] == 1)
            //    {
            //        sum++;
            //    }
            //}
            //Console.WriteLine("-----------------");
            //Console.WriteLine($"Sum = {sum / 2}");
            Console.ReadLine();
        }
    }
}
