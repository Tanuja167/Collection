using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Collection
{
    internal class SortedList1
    {
        static void Main(string[] args)
        {
            SortedList ht = new SortedList();
            ht.Add(01, "Computer");
            ht.Add(02, "Civil");
            ht.Add(03, "E&TC");
            ht.Add(04, "Production");

            ht.Remove(01);// based on key data will be removed from the hashtable

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }

    }
}
