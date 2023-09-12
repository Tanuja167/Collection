using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OopsPrograms.Collection
{
    internal class Arraylist
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 11, 21, 31, 41 };
            ArrayList arraylist = new ArrayList();
            arraylist.Add(11);
            arraylist.Add(33);
            arraylist.Add(22);
            foreach(int i in arraylist)
            {
                Console.WriteLine(i);
            }

            arraylist.Sort();                              //asending
            Console.WriteLine("after sort");
            foreach (int i in arraylist)
            {
                Console.WriteLine(i);
            }
            arraylist.Reverse();                       //desending
            Console.WriteLine("After reverse: ");
            foreach (int i in arraylist)
            {
                Console.WriteLine(i);
            }
            arraylist.Insert(1, 1.5);
            arraylist.AddRange(arr);                //convert array to list
            arraylist.Remove(33);
            
            
            Console.WriteLine("Count total number of ele: " + arraylist.Count);
            Console.WriteLine(arraylist.Capacity);

            foreach (int i in arraylist)
            {
                Console.WriteLine(i);
            }

            

         
          
        }
    }
}
