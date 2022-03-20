using System;

namespace LinkedListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30); 
            list.Add(40);

            list.Add(70);
            Console.WriteLine("The LinkedList Sequence is :");
            list.Display();

            Console.WriteLine("-------------------------");
            
            Console.WriteLine("After deleting 40: ");
            list.Delete(40);
            list.Display();

            Console.WriteLine("-------------------------");
            Console.WriteLine("The size of the Linkedlist is :");
            list.Size();
          
            
        }
    }
}