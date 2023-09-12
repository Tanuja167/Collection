using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Collection
{
    internal class generichashset
    {
        static void Main(string[] args)
        {
            HashSet<string> set1 = new HashSet<string>();
            set1.Add("C");
            set1.Add("C++");
            set1.Add("C#");
            set1.Add("JAVA");

            Console.WriteLine("First list");
            foreach (string s in set1)
            {
                Console.WriteLine(s);
            }

            HashSet<string> set2 = new HashSet<string>();
            set2.Add("Python");
            set2.Add("C++");
            set2.Add("Angular");
            set2.Add("JAVA");

            
            
            Console.WriteLine("\n Second list");
            foreach (string s1 in set2)
            {
                Console.WriteLine(s1);
            }

            /*Console.WriteLine("\n After union : ");
            set1.UnionWith(set2);

            foreach (string s2 in set1)
            {
                Console.WriteLine(s2);
            }*/

            Console.WriteLine("after intersect");
            set1.IntersectWith(set2);
            foreach(string s1 in set2)
            {
                Console.WriteLine(s1);
            }


        }
    }
}
