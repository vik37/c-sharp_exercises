using Exercise_13_LinkedList;
using System;

namespace Exercise_13_LinkedList
{
    public class LinkedList
    {
        public Node Head;
        //public int Count { get; set; }

        //public LinkedList()
        //{
        //    Head = null;
        //    Count = 0;
        //}
        public void Push(int new_data)
        {
            Node newNode = new Node(new_data);
            newNode.Next = Head;
            Head = newNode;
        }
        public void After(Node prev_node,int new_data)
        {
            if(prev_node == null)
            {
                Console.WriteLine("The given previous node" +
                                " cannot be null");
                return;
            }
            Node newNode = new Node(new_data);
            newNode.Next = prev_node.Next;
            prev_node.Next = newNode;
        }
        public void append(int new_data)
        {
            Node newNode = new Node(new_data);
            if(Head == null)
            {
                Head = new Node(new_data);
                return;
            }
            newNode.Next = null;
            Node last = Head;
            while (last.Next != null)
            {
                last = last.Next;
                last.Next = newNode;
                return;
            }
        }
        public void Display()
        {
            Node tnode = Head;
            while (tnode != null)
            {
                Console.WriteLine(tnode.Data + " ");
                tnode = tnode.Next;
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list1 = new LinkedList();
            list1.Push(2);
            //list1.Push(5);
            //list1.Push(7);
            //list1.Push(11);
            //list1.Push(12);
            //list1.After(list1.Head.Next.Next.Next.Next, 17);
            list1.After(list1.Head, 17);
            list1.After(list1.Head, 18);
            list1.After(list1.Head, 19);
            list1.After(list1.Head, 20);
            list1.Display();
            Console.ReadLine();
        }
    }
}
