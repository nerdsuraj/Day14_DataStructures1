using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_DataStructures1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program for Stack");

            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Peek();

            linkedListStack.Pop();
            linkedListStack.IsEmpty();
            Console.ReadLine();
        }
    }
}
