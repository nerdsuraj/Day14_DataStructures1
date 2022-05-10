using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingLinkList
{
    internal class LinkedListQueue
    {
        Node head = null;

        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                //node.next = head;

            }
            Console.WriteLine("{0} inserted into queue ", node.data);

        }
        internal void Peek()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the Queue ", this.head.data);
        }
        internal void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value  is dequeue {0} ", this.head.data);
            this.head = this.head.next;
        }
        internal void IsEmpty()
        {
            while (this.head != null)
            {
                Peek();
                Dequeue();
            }
        }
    }
}
