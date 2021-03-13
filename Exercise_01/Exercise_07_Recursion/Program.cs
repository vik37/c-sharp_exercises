using System;

namespace Exercise_07_Recursion
{
    class Program
    {
        public static int Summation(int n)
        {
            if(n <= 0)
            {
                return n;
            }
            else
            {
                // 3 + Summation(2)
                //3 + 2 = Summation(1)
                //3 + 2 + 1 = Summation(0)
                //3+2+1+0 = 6
                return n + Summation(n - 1);
            }
        }
        public static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                // 4 * Factorial(3)
                // 4 * 3 * Factorial(2)
                //4 * 3 * 2 * Factorial(1)
                //4 * 3 * 2 * 1 
                return n * Factorial(n - 1);
            }
        }
        public static int Exponentiation(int n, int p)
        {
            if(p <= 0)
            {
                return 1;
            }
            else
            {
                // p = 3
                // 5 * Exponentiation(5,2)
                //5 * 5 * Exponentiation(5,1)
                //5 * 5 * 5 * Exponentiation(5,0)
                //5 * 5 * 5 * 5 * 1 = 125
                return n * Exponentiation(n, p - 1);
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(Summation(3));
            //Console.WriteLine(Factorial(4));
            //Console.WriteLine(Exponentiation(5, 4));
            int a = Exponentiation(5, 4);
            Console.WriteLine(a);
            Console.WriteLine("---------------------------");
            //double a = 4.0;
            //double b = 4.0;
            //double c = a + b;
            //Console.WriteLine(c.ToString("n1"));
            
            Console.ReadLine();
        }
    }
}
