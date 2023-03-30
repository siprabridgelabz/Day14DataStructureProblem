using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14DataStructureProblem
{
    public class QueueLinkedList
    {
        public Node head = null;
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            if (this.head == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.head;
            }
            this.head = node;
            Console.WriteLine("{0} pushed to Queue", value);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list for Queue seems to be empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }

        }
        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty,Dequeue is not possible.");
                return;
            }
            while (head != null)
            {
                Console.WriteLine($"Value dequeue is {head.data}");
                head = head.next;
            }

        }
    }
}
