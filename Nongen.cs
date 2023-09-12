using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Collection
{
    internal class Nongen
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List...................");
            List<string> obj = new List<string>();

            obj.Add("ABC");
            obj.Add("DEF");

           
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
            obj.Sort();
            Console.WriteLine("After Sort");
            foreach(var item in obj)
            {
                Console.WriteLine(item);
            }

            obj.Remove("ABC");
            Console.WriteLine("After remove: ");
            foreach(var item in obj)
            {
                Console.WriteLine(item);
            }
            obj.RemoveAt(0);
            Console.WriteLine("Count: "+obj.Count());

            Console.WriteLine("capacity: "+obj.Capacity);
            Console.WriteLine();
            Console.WriteLine("Stack.........................");

            Stack<int> st1 = new Stack<int>();
            st1.Push(1);
            st1.Push(2);
            st1.Push(3);
            st1.Push(4);
            Console.WriteLine("After push: ");

            foreach (var item in st1)
            {
                Console.WriteLine(item);
            }

            st1.Pop();
            Console.WriteLine("After pop: ");
            foreach( var item in st1)
            {
                Console.WriteLine(item);
            }

            
            Console.WriteLine("After Peek: "+st1.Peek());
            
            st1.Clear();

            Console.WriteLine("After clear: ");
            foreach(var item in st1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Queue.........................");

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(11);
            queue.Enqueue(21);
            queue.Enqueue(31);
            queue.Enqueue(41);

            Console.WriteLine("After enque: ");
            foreach(var item in  queue)
            {
                Console.WriteLine(item);
            }

            queue.Dequeue();
            Console.WriteLine("After dequeue: ");
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }

            

              


        }
    }
}
