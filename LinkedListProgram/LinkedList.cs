using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    internal class LinkedList
    {
        internal Node head;

        public void addFirst(string data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                return;
            }
            node.next = head;
            head = node;
        }
        public void addLast(string data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                return;
            }

            Node currNode = head;
            while (currNode.next != null)
            {
                currNode = currNode.next;
            }
            currNode.next = node;
        }
        public void Search(string data)
        {
            while (this.head != null)
            {
                if (this.head.data == data)
                {
                    return;
                }
                this.head = this.head.next;
            }
            return;
        }

        public void printlist()
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");
                return;
            }
            Node currNode = head;
            while (currNode != null)
            {
                Console.WriteLine(currNode.data + " -> ");
                currNode = currNode.next;
            }
        }
        public void deleteFirst(string data)
        {
            if (head == null)
            {
                Console.WriteLine("This list is empty");
                return;
            }
            head = head.next;
        }
        public void deleteLast(string data)
        {
            if (head == null)
            {
                Console.WriteLine("this list is empty");
                return;
            }

            if (head.next == null)
            {
                head = null;
                return;
            }

            Node secondlast = head;
            Node lastnode = head.next;
            while (lastnode.next != null)
            {
                lastnode = lastnode.next;
                secondlast = secondlast.next;
            }
            secondlast.next = null;
        }
        internal Node InsertAtParticularPosition(int position, string data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node temp = this.head;
                while (position != 0) //
                {

                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    temp = temp.next;//1000
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }
    }
}
