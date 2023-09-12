using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OopsPrograms.Collection
{
    internal class Queue11
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            que.Enqueue(10);
            que.Enqueue(20);
            que.Enqueue(30);
            que.Enqueue(40);

            Console.WriteLine("Queue after enqueue operation: ");
            foreach(var item in que)
            {
                Console.WriteLine(item);
            }

            que.Dequeue();
            foreach(var item in que)
            {
                Console.WriteLine(item);
            }


        }
    }
}
