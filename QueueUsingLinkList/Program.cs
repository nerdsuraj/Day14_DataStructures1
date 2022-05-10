using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingLinkList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program for Queue");
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Peek();

            linkedListQueue.Dequeue();
            linkedListQueue.IsEmpty();

            Console.ReadLine();
        }
    }
}
