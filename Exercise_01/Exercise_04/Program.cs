using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_04
{
    class Program
    {
        static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            List<int> points = new List<int>();
           
            int alice = 0;
            int bob = 0;

            if(a[0] > b[0])
            {
                alice ++;
            }
            else if (a[0] < b[0])
            {
                bob ++;
            }
            if (a[1] > b[1])
            {
                alice ++;
            }
            else if (a[1] < b[1])
            {
                bob ++;
            }
            if (a[2] > b[2])
            {
                alice ++;
            }
            else if (a[2] < b[2])
            {
                bob ++;
            }
          

            //for (int i = 0; i < a.Count; i++)
            //{
            //    for (int j = 0; j < b.Count; j++)
            //    {
            //        if((a[i] <= 1) || (a[i] >= 100))
            //        {
            //            points.Add(0);
            //            Console.WriteLine("A Canot be lass then 0");
            //            return points;

            //        }
            //        else if((b[j] <= 1) || (b[j] >= 100))
            //        {
            //            points.Add(0);
            //            Console.WriteLine("B Canot be lass then 0");
            //            return points;
            //        }
            //        else
            //        {

            //             if (a[i] > b[j])
            //            {
            //                alicePoints.Add(1);
            //            }
            //             else if(a[i] < b[j])
            //            {
            //                bobPoints.Add(1);
            //            }                                                
            //            else
            //            {
            //                alicePoints.Add(0);
            //                bobPoints.Add(0);
            //            }
            //        }

            //    }
            //}


            points.Add(alice);
            points.Add(bob);
            return points;
        }
        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp =>
            Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp =>
            Convert.ToInt32(aTemp)).ToList();

            List<int> result = CompareTriplets(a, b);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }
    }
}
