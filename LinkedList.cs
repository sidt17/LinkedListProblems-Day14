using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListDemo
{
    class LinkedList
    {
        public Node head;
        public void AddLast(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            //Console.WriteLine("{0} inserted into linked list", node.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        public void AddFirst(int data)
        {
            Node NewNode = new Node(data);
            if (head == null)
            {
                Console.WriteLine("linked list is null");
                return;
            }
            else
            {
                NewNode.next = head;
                head = NewNode;
            }
            

            
        }
    }
}