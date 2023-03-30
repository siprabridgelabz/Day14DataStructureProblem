using Day14DataStructureProblem;
using System.Collections.Generic;

namespace Day14DataStuctureProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue program:");
            Console.WriteLine("********");

            // StackAddLinkedList linkedlist = new StackAddLinkedList();
            //  linkedlist.Push(56);
            //linkedlist.Push(30);
            //linkedlist.Push(70);

            //Console.WriteLine("**************************************************");
            //Console.WriteLine("Now the stack contains : ");

            //linkedlist.Display();

            //linkedlist.Peak();
            //linkedlist.Pop();

            //linkedlist.Display();
            //linkedlist.Peak();

            QueueLinkedList linkedlist = new QueueLinkedList();
           // linkedlist.Enqueue(56);
           // linkedlist.Enqueue(30);
           // linkedlist.Enqueue(70);

           // linkedlist.Display();

           // linkedlist.Enqueue(56);
           // linkedlist.Enqueue(30);
           // linkedlist.Enqueue(70);
            Console.WriteLine("*******************************************************");
            linkedlist.Display();
            Console.WriteLine("*******************************************************");
            linkedlist.Dequeue();
            Console.WriteLine("*******************************************************");
            linkedlist.Display();
            Console.WriteLine("*******************************************************");
            Console.ReadLine();



        }
    }
}
