using System;

namespace Exercise_15_Exceptions
{
    public class Calculator
    {
        //public int FirstNum { get; set; }
        //public int SecondNum { get; set; }

        public int Power(int n, int p)
        {  
            if(n < 0 || p < 0)
            {
                throw new SomeException("a or b should be non-negative number.");
            }
            //if(n > 0 || p > 0)
            //{
                if (p == 0)
                {
                    return 1;
                    
                }
                else
                {
                    return n * Power(n, p - 1);
                }
               
            //}
            //else
            //{
            //    throw new SomeException("a or b should be non-negative number.");
            //}
            
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int a = 2;
            int b = 4;
            try
            {
                int ans = calc.Power(a, b);
                Console.WriteLine($"REsult is: {ans}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
