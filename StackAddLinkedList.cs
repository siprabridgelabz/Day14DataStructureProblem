using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14DataStructureProblem
{
    public class StackAddLinkedList
    {
        
        public Node top;

        public StackAddLinkedList()
        {
            this.top = null;
        }
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }
        public void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }

        }
        public void Peak()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack seems empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack", this.top.data);
        }

        public  void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack has been emptyed, Further Deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped from the stack is {0}", this.top.data);
            this.top = this.top.next;
        }




    }
}

