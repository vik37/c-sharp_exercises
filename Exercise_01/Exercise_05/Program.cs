using System;

namespace Exercise_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //char c = 'C';
            //Console.WriteLine($"The ASCII value of {c} is {(int)c}");

            //string s = "Hacker";          
            //for (int i = 0; i < s.Length; i++)
            //{
            //    //if(i >= 0 && i <= s.Length - 1)
            //    //{
            //        if (i % 2 == 0)
            //        {
            //            Console.Write(s[i]);
            //        }

            //   // }              
            //}
            //Console.Write("  ");
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.Write(s[i]);
            //    }
            //}

            //int t = 2;
            //int j = 0;
            //while(j >= 0 && j <= t - 1)
            //{
            //    Console.WriteLine(s);
            //    j++;
            //}

            #region
            //int n = 4;
            //int[] a = new int[] { 1, 2, 3, 4 };
            //for(int i = n - 1;i >= 0; i--)
            //{
            //    Console.Write(a[i] + " ");
            //}
            #endregion
            #region

            int[] arr = new int[] { 1, 1, 0, -1, -1 };
            int[] positive = new int[] { };
            int[] zero = new int[] { };
            int[] negative = new int[] { };
            int allSum = 0;
            double sum = 0;
            float procent = 0f;
            for(int i = 0;i < arr.Length; i++)
            {

                allSum += 1;
                if(arr[i] > 0) {
                    sum += 1;

                    
                    Console.WriteLine(arr[i]);
                }
            }
            Console.WriteLine($"All Sum: {allSum}");
            Console.WriteLine($" Sum = {sum}");
            procent = (float)sum / allSum * procent;
            Console.WriteLine($" Procent = {procent}");
            //foreach (var item in positive)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            Console.ReadLine();
        }
    }
}
