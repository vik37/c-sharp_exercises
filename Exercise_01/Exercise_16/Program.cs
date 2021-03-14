using System;

namespace Exercise_16
{
    class Program
    {
        public static void PlusMinus(int[] arr)
        {
            double positive = 0;
            double zero = 0;
            double negative = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    Console.WriteLine(arr[i]);
                    positive++;
                }
                if(arr[i] == 0)
                {
                    zero++;
                }
                if(arr[i] < 0)
                {
                    negative++;
                }
            }
            var sum1 = String.Format("{0:n6}", positive / arr.Length);
            var sum2 = String.Format("{0:n6}", Math.Abs(negative / arr.Length));
            var sum3 = String.Format("{0:n6}", zero / arr.Length);
            Console.WriteLine($"positive length: {positive}");
            Console.WriteLine($"negative length: {negative}");
            Console.WriteLine($"zero length: {zero}");
            Console.WriteLine("_________________________________________");
            Console.WriteLine($"Sum positive length: {sum1}");
            Console.WriteLine($"Sum negative length: {sum2}");
            Console.WriteLine($"Sum zero length: {sum3}");
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            PlusMinus(arr);
            Console.ReadLine();
        }
    }
}
