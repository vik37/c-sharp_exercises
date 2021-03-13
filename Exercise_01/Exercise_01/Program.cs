using System;

namespace Exercise_01
{
   

   

    class Program
    {
        //static void Solve(double meal_cost, int tip_precent, int tax_precent)
        //{

        //    double tip = meal_cost / 100 * tip_precent;
        //    double tax = meal_cost / 100 * tax_precent;
        //    double totalcost = meal_cost + tip + tax;
        //    Console.WriteLine(Math.Round(totalcost));
            
            
        //}
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n <= 1 || n >= 100)
            {
                Console.WriteLine("Number can not be less then 0 and bigger then 100");
            }
            else
            {
               
                
                string a = n % 2 == 0 ? "even" : "odd";
                if (a == "even")
                {
                    if (n >= 2 || n <= 5)
                    {
                        Console.WriteLine("Not Weard");
                    }
                    else if (n >= 6 && n <= 20)
                    {
                        Console.WriteLine("Weird");
                    }
                    else 
                    {
                        Console.WriteLine("Not Weaird");
                    }
                    //else
                    //{
                    //    Console.WriteLine("Not Weird");
                    //}
                    //Console.WriteLine("Not Weard");
                 }
                if (a == "odd")
                {
                    Console.WriteLine("Weard");
                }
                //Console.WriteLine(a);

            }


            //Console.WriteLine(a);
            
            //double meal_cost = 12.00;
            //int tip_precent = 20;
            //int tax_precent = 8;
            //Solve(meal_cost, tip_precent, tax_precent);
            Console.ReadLine();
        }
    }
}
