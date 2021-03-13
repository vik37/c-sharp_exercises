using System;

namespace Exercise_11_Inheritance
{
    public class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;
        public Person() { }

        public Person(string firstName, string lastName, int identificator)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identificator;
        }
        public void PrintPerson()
        {
            Console.WriteLine($"Name: {lastName}, {firstName} \nID: {id}");
        }
    }
    public class Student : Person
    {
        private int[] testScore;
        public Student(string firstName,string lastName,int identificator,int[] testScore) 
            : base(firstName,lastName,identificator)
        {
            if(firstName.Length <= 1 || firstName.Length >= 10)
            {
                this.firstName = "";
                Console.WriteLine("First name can not be lass then 1 and larger then 10");
            }
            if (lastName.Length <= 1 || lastName.Length >= 10)
            {
                this.lastName = "";
                Console.WriteLine("Last name can not be lass then 1 and larger then 10");
            }
            if(identificator <= 1000000 || identificator > 10000000)
            {
                this.id = 0;
                Console.WriteLine("Id can not be less then or larger then 7digits");
            }
            this.testScore = testScore;
        }

        public char Calculate()
        {
            char grade = '.';
            foreach (var a in testScore)
            {
                if(a >= 0 || a <= 100)
                {
                    if (a <= 100 && a >= 90)
                    {
                        grade = 'O';
                    }
                    else if (a < 90 && a >= 80)
                    {
                        grade = 'E';
                    }
                    else if (a < 80 && a >= 70)
                    {
                        grade = 'A';
                    }
                    else if (a < 70 && a >= 55)
                    {
                        grade = 'P';
                    }
                    else if (a < 55 && a >= 40)
                    {
                        grade = 'D';

                    }
                    else
                    {
                        grade = 'T';
                    }
                }
                else
                {
                    Console.WriteLine("score must be latger then 0 and less then or equal to 100");
                }
               
            }
            return grade;
        }
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            string firstname = inputs[0];
            string lastname = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScore = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScore];
            for (int i = 0; i < numScore; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstname, lastname, id, scores);

            s.PrintPerson();

            Console.WriteLine($"Grade: {s.Calculate()} \n");


            //foreach (var item in inputs)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadLine();
        }
    }
}
