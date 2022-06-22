using System;

namespace LinkedListDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedlist = new LinkedList();
            linkedlist.Add(56);
            linkedlist.Append(30);
            linkedlist.Append(70);

            Console.WriteLine("Final LinkedList sequence is- ");
            linkedlist.Display();






        }
    }
}
