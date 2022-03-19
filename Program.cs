using System;

namespace LinkedListDemo
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
            
            Console.WriteLine("Search element");
            list.Search(56);
            list.Display();
        }
    }
}
