using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Collection
{
    internal class Assign2
        /*WAP to create an array of 5 strings to store students name, sort names in ascending order & display using foreach loop.*/
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Tanu");
            list.Add("Alisha");
            list.Add("Pooja");
            list.Add("Rutu");
            list.Add("Shiv");
            Console.WriteLine("After storing names: ");

            foreach (string i in list)
            {
                Console.WriteLine(i);
            }

           list.Sort();
            Console.WriteLine("After sorting in asending order: ");
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }

        }
    }
}
