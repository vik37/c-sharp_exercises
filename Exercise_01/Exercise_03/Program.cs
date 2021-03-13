using System;

namespace Exercise_03
{
    //class Person
    //{
    //    public int Age { get; set; }
    //    public Person(int initialAge)
    //    {
                       
    //        if(initialAge >= 0)
    //        {
    //            Age = initialAge;
    //        }
    //        else
    //        {
    //            Age = 0;
    //            Console.WriteLine("Age is not valid, setting age to 0.");
    //        }
    //    }
    //    public void amIOld()
    //    {
    //        if(Age < 13)
    //        {
    //            Console.WriteLine("You are young.");
    //        }
    //        else if((Age >= 13) && (Age < 18))
    //        {
    //            Console.WriteLine("You are a teenager.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("You are old.");
    //        }
    //    }

    //    public void yearPasses()
    //    {
    //        Age++;
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            //int T = int.Parse(Console.ReadLine());
            ////if(T >= 1 || T <= 4)
            ////{
            //    for (int i = 0; i < T; i++)
            //    {
            //        int age = int.Parse(Console.In.ReadLine());
            //        if(age >= 5 || age <= 30)
            //        {
            //            Person p = new Person(age);
            //            p.amIOld();
            //            for (int j = 0; j < 3; j++)
            //            {
            //                p.yearPasses();
            //            }
            //            p.amIOld();
            //            Console.WriteLine();
            //        }

            //    }
            ////}

            //double a = 4.0;
            //double b = 4.0;

            //Console.WriteLine(a + b + .0);

            #region
            int n = Convert.ToInt32(Console.ReadLine());

            if(n >= 2 || n <= 20)
            {
                for (int i = 0; i <= 10; i++)
                {
                    if(i >= 1 && i <= 10)
                    {
                        int result = n * i;
                        Console.WriteLine(n + " x " + i + " = " + result);
                    }
                    
                }
            }

            #endregion

            Console.ReadLine();
        }
    }
}
