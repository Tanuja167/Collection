using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Collection
{
    internal class Stack11
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            stack.Pop();
            Console.WriteLine("After Pop: ");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            
            Console.WriteLine("Peek Value is: "+stack.Peek());
        }
    }
}
