using System;

namespace LinkedListDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedlist = new LinkedList();
            linkedlist.Add(70);
            linkedlist.Add(30);
            linkedlist.Add(56);

            linkedlist.Display();

        }
    }
}
