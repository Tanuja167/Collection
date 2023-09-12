using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OopsPrograms.Collection
{
    internal class Assign6Arraylist
    {
        /*WAP to create a list using ArrayList. Iterate over collections to display data.*/
        static void Main(string[] args)
        {
            
            ArrayList arraylist = new ArrayList();
            Console.WriteLine("enter elements: ");

            for (int i=1;i<5;i++)
            {
                arraylist[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(arraylist[i]);
                
            }
            foreach(int i in arraylist)
            {
                Console.WriteLine(i);
            }
        }

    }
}
