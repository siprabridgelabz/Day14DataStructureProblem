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

            StackAddLinkedList linkedlist = new StackAddLinkedList();
            linkedlist.Push(56);
            linkedlist.Push(30);
            linkedlist.Push(70);

            

            linkedlist.Display();
           

        }
    }
}
