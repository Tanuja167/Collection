using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Collection
{
    internal class Assign1
    {
        /*WAP to create an array of 5 integers. Initialize 5 values. Display using foreach loop.*/
        static void Main(string[] args)
        {
             List<int> list = new List<int>();
             list.Add(11);
             list.Add(22);
            list.Add(33);
            list.Add(44);
            list.Add(55);
            Console.WriteLine("After adding 5 elements: ");

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
