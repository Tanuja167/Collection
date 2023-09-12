using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Collection
{
    internal class NongenDict
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(97, "india");
            dict.Add(32, "china");
            dict.Add(34, "Pakistan");

            Console.WriteLine("After add: ");

            foreach (KeyValuePair<int, string> item in dict) 
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            dict.Remove(34);
            Console.WriteLine("After remove: ");

            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
