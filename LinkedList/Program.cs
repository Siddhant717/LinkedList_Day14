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
            Console.WriteLine("Final LinkedList Sequence before using Pop Method Is- ");
            linkedlist.Display();
            linkedlist.Pop();
            Console.WriteLine("Final LinkedList Sequence after applied Pop Method Is- ");
            linkedlist.Display();






        }
    }
}
