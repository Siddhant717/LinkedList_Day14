using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class LinkedList
    {

        private Node head;

        public class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
            }
        }

        public bool Add(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return true;
            }
            n.next = head;
            head = n;
            return true;

            
        }

        public bool Append(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return true;
            }

            Node t = head;
            while (t.next != null)
            {
                t = t.next;
            }
            t.next = n;
            return true;
        }
        public void Display()
         {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
