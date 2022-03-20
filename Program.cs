using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List sequence is");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();


            Console.WriteLine("-------------------------");
            Console.WriteLine("Search element is ");
            list.Search(30);
            list.Display();
            Console.WriteLine("-------------------------");
            list.InsertAtParticularPosition(2, 40);
            Console.WriteLine("The list after inserting 40 is :  ");
            list.Display();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Final sequence of list is ");
            list.InsertAtParticularPosition(1, 56);
            list.Display();
            
        }
    }
}
