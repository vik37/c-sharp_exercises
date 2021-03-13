using System;
using System.Collections.Generic;

namespace Exercise_06_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //var n = new Dictionary<string, int>() { { "sam", 99912222 },{"tom",11122222 }, { "harry", 12299933 } };

            var n = new Dictionary<string, int>();
            int count = int.Parse(Console.ReadLine());
            int count2 = count;
            
            while (count > 0)
            {
                Console.WriteLine("enter string");
                string s = Console.ReadLine();
                Console.WriteLine("enter number");
                int m = int.Parse(Console.ReadLine());
                n.Add(s, m);
                count--;
            }
            while(count > 0)
            {
                Console.WriteLine("enter names");
                string query = Console.ReadLine();
                if (n.ContainsKey(query))
                {
                    
                    Console.WriteLine($"{query} = {n[query]}");
                }
                else
                {
                    Console.WriteLine("Not found");
                    
                }
                count--;
            }
            
            

            Console.ReadLine();
        }
    }
}
