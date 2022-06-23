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

            Console.WriteLine("LinkedList Sequence Is- ");
           
            linkedlist.Display();

            Console.WriteLine("-------------------------");
           bool flag= linkedlist.Search(30);
            Console.WriteLine(flag);

            Console.WriteLine("-------------------------");
            linkedlist.Insert(2, 40);
            Console.WriteLine(" Now Final LinkedList Sequence Is- ");
            linkedlist.Display();






        }
    }
}
