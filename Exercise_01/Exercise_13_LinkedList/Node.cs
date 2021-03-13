using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_13_LinkedList
{
    public class Node
    {
        public Node Next { get; set; }
        public int Data { get; set; }
        public Node(int newData)
        {
            Data = newData;
            Next = null;
        }
        //public Node(int newData,Node newNode)
        //{
        //    Data = newData;
        //    Next = newNode;
        //}
        
    }
}
