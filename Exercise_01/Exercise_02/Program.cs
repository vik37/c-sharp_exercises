using System;

namespace Exercise_02
{
    class Program
    {
        public class Car
        {
            public int MaxSpeed { get; set; } = 100;
            public int MinSpeed { get; set; } = 0;
            public double Weight { get; set; } = 4079;
            public bool IsTheCarOn { get; set; } = false;
            public char Condition { get; set; } = 'A';
            public string NameOfCar { get; set; } = "Lucy";

            public double MaxFuel { get; set; } = 16;
            public double CurrentFuel { get; set; } = 8;
            public double Mpg { get; set; } = 26.4;

            public int NumberOfPeopleInCar { get; set; } = 1;

            int maxNumberOfPeopleInCar = 6;
            public Car(int minSpeed, double weight, bool isTheCarOn)
            {
                MinSpeed = minSpeed;
                Weight = weight;
                IsTheCarOn = isTheCarOn;
            }
            public Car() { }
            
            public void PrintProperties()
            {
                Console.WriteLine($"This is the maxSpeed {MaxSpeed}");
                Console.WriteLine($"{MinSpeed}");
                Console.WriteLine($"{Weight}");
                Console.WriteLine($"{IsTheCarOn}");
                Console.WriteLine($"{Condition}");
                Console.WriteLine($"{NameOfCar}");
            }


            public void UpgradeMinSpeed()
            {
                MinSpeed = (MaxSpeed + 1);

            }
            public void GetIn()
            {
                if(NumberOfPeopleInCar < maxNumberOfPeopleInCar)
                {
                    NumberOfPeopleInCar++;
                    Console.WriteLine("Someone got in");
                }
                else
                {
                    Console.WriteLine("The car is full " + NumberOfPeopleInCar + " + " + maxNumberOfPeopleInCar);
                }
                
            }
            public void GetOut()
            {
                if(NumberOfPeopleInCar > 0)
                {
                    NumberOfPeopleInCar--;
                }
                else
                {
                    Console.WriteLine("No one is in the car " + NumberOfPeopleInCar);
                }
                
            }
            public double HowManyMilesTillOutOfGass()
            {
                return CurrentFuel * Mpg;
            }
            public double MaxMilesPerFillUp()
            {
                return MaxFuel * Mpg;
            }
            public void TurnTheCarOn()
            {
                if(!IsTheCarOn)
                {
                    IsTheCarOn = true;
                }
                else
                {
                    Console.WriteLine("The car is already on " + IsTheCarOn);
                }
            }
        }
        static void Main(string[] args)
        {
            Car tommyCar = new Car();
            tommyCar.GetOut();
            tommyCar.GetOut();
            tommyCar.GetIn();
            tommyCar.GetIn();
            tommyCar.GetIn();
            tommyCar.GetIn();
            tommyCar.GetIn();
            tommyCar.GetIn();
            tommyCar.TurnTheCarOn();
            tommyCar.TurnTheCarOn();
            Console.ReadLine();
        }
    }
}
