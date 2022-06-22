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
            Console.WriteLine("Final LinkedList Sequence Is- ");
           
            linkedlist.Display();
            Console.WriteLine("-------------------------");
           bool flag= linkedlist.Search(30);
            Console.WriteLine(flag);







        }
    }
}
