using System;

namespace Exercise_10_multyDArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] parties = new int[3][];
            //parties[0] = new[] { 1, 2, 3, 4, 5 };
            //parties[1] = new[] { 11, 12, 13, 14, 15, 16, 17 };
            //parties[2] = new[] { 21, 22, 23 };

            //int[,] home = new int[3, 6]
            //{
            //    {1,2,3,4,5,6 },
            //    { 11,12,13,14,15,16},
            //    { 21,22,23,24,25,26},
            //};
            //Console.WriteLine(home[0,5]);
            //Console.WriteLine("----------------------");

            //var allLength = home.Length;
            //int count = 1;
            //for(int i = 0;i < home.Rank; i++)
            //{
            //    count *= home.GetLength(i);
            //}
            //Console.WriteLine($"{allLength} = {count}");
            //for (int i = 0; i < home.GetLength(0); i++)
            //{
            //    for (int j = 0; j < home.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"{home[2,5]} {home[i,2] }");
            //    }
            //}
            //for (int i = 0; i < parties.Length; i++)
            //{
            //    for (int j = 0; j < parties[i].Length; j++)
            //    {
            //        Console.WriteLine(parties[1][2]);
            //    }
            //}

            #region
            int[][] arr = new int[6][];
            arr[0] = new int[] { 1, 1, 1, 0, 0, 0 };
            arr[1] = new int[] { 0, 1, 0, 0, 0, 0 };
            arr[2] = new int[] { 1, 1, 1, 0, 0, 0 };
            arr[3] = new int[] { 0, 0, 2, 4, 4, 0 };
            arr[4] = new int[] { 0, 0, 0, 2, 0, 0 };
            arr[5] = new int[] { 0, 0, 1, 2, 4, 0 };
            int bigger = arr[0][0];
            int[][] biggest = new int[3][];
            int sum = 0;
            for (int y = 0; y < 6; y++)
            {
                for (int x = 0; x < 6; x++)
                {
                    if(bigger < arr[x][y])
                    {
                        bigger = arr[x][y];
                        biggest = new int[x][];
                        
                        sum += arr[1][y];
                        
                    }
                }
            }
            for (int i = 0; i < biggest.Length; i++)
            {
                for (int j = 0; j < biggest[i].Length; j++)
                {
                    Console.WriteLine($"Biggest: {biggest[0][0]}");
                }
            }

            Console.WriteLine(bigger);
            Console.WriteLine($"Sum - {sum}");
            
            #endregion
            Console.ReadLine();
        }
    }
}
