using System;
using System.Linq;

namespace Exercise_12
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;
        public Difference(int[] elements)
        {
           
            this.elements = elements;
            
            ComputeDifference();
        }
        
        public int ComputeDifference()
        {
            
            int max = 0;
            int min = 0;
            max = elements.Max();
            min = elements.Min();
               
                //for (int j = elements.Length - 1; j > 0; j--)
                //{
                //    count = elements[i] - elements[j];
                //}
            
            Console.WriteLine($"Max: {max} - Min: {min}");

            return this.maximumDifference =  max - min;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // string time = "hh:mm:ss tt";
            // //string[] withoutPm = time.Split(":");
            // string[] withoutPm = time.Substring(0, time.Length - 3).Split(":");
            // string militaryTime = String.Format("{0}:{1}:{2}", withoutPm[0].ToUpper(), withoutPm[1], withoutPm[2]);
            // //Console.WriteLine(withoutPm[0]);
            // Console.WriteLine(militaryTime);

            // var a = DateTime.Now.ToString(militaryTime);
            //Console.WriteLine(a);

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);
            d.ComputeDifference();
            Console.WriteLine($"Difference: {d.maximumDifference}");
            Console.ReadLine();
        }
    }
}
