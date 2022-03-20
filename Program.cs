using System;


namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            LinkedList List = new LinkedList();
            List.AddLast(70);
            List.AddFirst(30);
            List.AddFirst(56);
            Console.WriteLine("Final LinkedList Sequence is :");
            List.Display();
        }
    }
}