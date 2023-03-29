using Day14DataStructureProblem;

namespace Day14DataStuctureProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue program:");
            Console.WriteLine("********");

            StackAddLinkedList obj = new StackAddLinkedList();
            obj.push(70);
            obj.push(30);
            obj.push(56);
            obj.Display();

        }
    }
}
