using System;
using System.Collections.Generic;

namespace Exercise_17_stackQueue
{
    class Program
    {
        static Queue<string> QueueNames(List<string> listNames)
        {
            Queue<string> names = new Queue<string>();
            foreach (var item in listNames)
            {
                if(item != null)
                {
                    names.Enqueue(item);
                }
                else
                {
                    Console.WriteLine("List of names are empty!");
                }
            }
            return names;
        }
        static Queue<string> DequeueNames(Queue<string> names)
        {
            //if(names.Contains("Cecko"))
                names.Dequeue();
            return names;
        }
        static void ShowNames(Queue<string> names)
        {
            int count = 0;
            foreach (var item in names)
            {
                count++;
                if(item != null)
                {
                    Console.WriteLine($"NAME {count}: {item}");
                }
            }
        }
        static Stack<string> AddTransferedNames(Queue<string> transNames)
        {
            Stack<string> transfer = new Stack<string>();
            foreach (var item in transNames)
            {
                transfer.Push(item);
            }
            return transfer;
        }
        static void ShowTransferNames(Stack<string> transfers)
        {
            int count = 0;
            Console.WriteLine("TRANSFER IN NEW CLAB THIS YEARS ARE:");
            foreach (var item in transfers)
            {
                if(item != null)
                {
                    Console.WriteLine($"No. {count} - {item}");
                }
            }
        }
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                "Sabri",
                "Cecko",
                "Cedka",
                "Ico"
            };
            //names.Enqueue("Sabri");
            //names.Enqueue("Cecko");
            //names.Enqueue("Cedka");
            //names.Enqueue("Ico");

            // Console.WriteLine($"Names: {names.Peek(1)}");
            //Stack<string> newNames = new Stack<string>();
            //newNames.Push("Dejan");
            //newNames.Push("Slaganja");
            //newNames.Push("Sasho");
            //foreach (var item in names)
            //{
            //    Console.WriteLine($"Names: {item}");
            //}
            //foreach (var item in newNames)
            //{
            //    Console.WriteLine($"New Names: {item}");
            //}
            Queue<string> transferredNames = QueueNames(names);
            Stack<string> finishTransfer = AddTransferedNames(transferredNames);
            
            DequeueNames(transferredNames);
            DequeueNames(transferredNames);
            DequeueNames(transferredNames);
            DequeueNames(transferredNames);
            ShowNames(transferredNames);
            ShowTransferNames(finishTransfer);
            Console.ReadLine();
        }
    }
}
