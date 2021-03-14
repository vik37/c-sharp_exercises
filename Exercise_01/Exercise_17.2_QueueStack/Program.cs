using System;
using System.Collections.Generic;

namespace Exercise_17._2_QueueStack
{
    class Program
    {
         Queue<char> queueWord { get; set; } = new Queue<char>();
         Stack<char> stackWord { get; set; } = new Stack<char>();
         void PushCharacter(char ch)
        {
            stackWord.Push(ch);
        }
         void EnqueueCharacter(char ch)
        {
            queueWord.Enqueue(ch);
        }
         char PopCharacter()
        {
            char ch = stackWord.Pop();
            return ch;
        }
         char DequeueCharacter()
        {
            char ch = queueWord.Dequeue();
            return ch;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            Program program = new Program();

            foreach (char c in s)
            {
                program.PushCharacter(c);
                program.EnqueueCharacter(c);
            }

            bool isPalindrom = true;

            for (int i = 0; i < s.Length / 2; i++)
            {
                if(program.PopCharacter() != program.DequeueCharacter())
                {
                    isPalindrom = false;
                    break;
                }
            }
            if (isPalindrom)
            {
                Console.WriteLine($"The word, {s}, is a palindrome.");
            }
            else
            {
                Console.WriteLine($"The word, {s}, is not a palindrome.");
            }
            Console.ReadLine();
        }
    }
}
