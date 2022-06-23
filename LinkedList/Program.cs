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
           

            linkedlist.Insert(2, 40);
           
            Console.WriteLine("Final LinkedList Sequence after adding 40 Is- ");
            linkedlist.Display();
            bool flag = linkedlist.Search(40);
            Console.WriteLine("-------------------------");
            Console.WriteLine(flag);
            Console.WriteLine("-------------------------");
            linkedlist.Pop(2);
            Console.WriteLine("Final LinkedList Sequence after deleting 40 Is- ");
            linkedlist.Display();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Size of Final LinkedList Sequence is- "+ linkedlist.Size());
          





        }
    }
}
