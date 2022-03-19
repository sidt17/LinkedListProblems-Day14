using System;
using System.Collections.Generic;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            list.RemoveFirstElement();
            Console.WriteLine("The list after removing first element is : ");
            list.Display();






        }
    }
}
