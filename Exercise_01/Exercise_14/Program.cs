using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_14
{
    class Program 
    { 
    
        public static int diagonalDifference(List<List<int>> arr)
        {
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Count; j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(arr[i][j]);
                        sum1 += arr[i][j];
                    }
                    if (i == arr.Count - j - 1)
                    {
                        Console.WriteLine($"Numbers reverse: {arr[i][j]}");
                        sum2 += arr[i][j];
                    }
                    //Console.WriteLine(arr[i][j]);
                }

            }

            Console.WriteLine($"Sum 1: {sum1}");
            Console.WriteLine("----------------------");
            Console.WriteLine($"Sum 2: {sum2}");
            int result = Math.Abs(sum1 - sum2);
            Console.WriteLine("---------------------------");
            return result;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp =>
                      Convert.ToInt32(arrTemp)).ToList());
            }

           
            Console.WriteLine($"Result is: {diagonalDifference(arr)}");
            
            Console.ReadLine();
        }
    }
}
