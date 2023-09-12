using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Collection
{
    internal class Assign6
    {
        /*WAP to accept an array of 5 integers. Perform Sort(), Reverse(), Copy(), Clear() operations.*/
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter array elements: ");
            for (int i=0;i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            Array.Sort(arr);
            Console.WriteLine("After sort : ");

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("After reverse: ");
            Array.Reverse(arr);

            foreach (int i in arr)
            { Console.WriteLine(i); }

            Console.WriteLine("After copy: ");
            int[] arr1 = new int[arr.Length];
           Array.Copy(arr, arr1, arr.Length);

            for(int i=0;i<arr1.Length;i++)
            {
                Console.WriteLine(arr1[i]);
            }

            
        }

    }
}
