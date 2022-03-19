using System;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(70);
            Console.WriteLine("The Linkedlist before inserting 30 is: ");
            list.Display();
            list.InsertAtParticularPosition(2, 30);
            Console.WriteLine("The Final Linkedlist after inserting 30 is: ");
            list.Display();


        }
    }
}
