using System;
using System.Collections.Generic;

namespace Exercise_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1,2,1,2,1,3,2 };
            List<int> dup = new List<int>();
            //int[] arr2 = arr;
            //Array.Reverse(arr2);
            //Array.Sort(arr);

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        dup.Add(arr[i]);
                        count++;
                    }
                }
                
            }
            Console.WriteLine(count / 2);
            //for(int i = 0;i < dup.Count; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        if(dup[i] ==  dup[j])
            //        {
            //            Console.WriteLine($"{dup[i]} -- {dup[j]}");
            //        }
            //    }
            //}

            //foreach (var item in dup)
            //{
            //    Console.WriteLine(item);
            //}
            // foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadLine();
        }
    }
}
