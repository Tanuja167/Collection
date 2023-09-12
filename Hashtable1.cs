using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OopsPrograms.Collection
{
    internal class Hashtable1
    {
        static void Main(string[] args)
        {
           Hashtable ht = new Hashtable();
            ht.Add(".India", 91);
            ht.Add(".China", 32);
            ht.Add("Pakistan", 43);

            foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            ht.Remove("Pakistan");
            Console.WriteLine("after remove :");
            foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
