using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OopsPrograms.Collection
{
    internal class Icomparable1
    {
        static void Main(string[] args)
        {
            Product pen = new Product(70, "pen");
            Product pencil = new Product(7, "pencil");

            int result = pen.CompareTo(pencil);
            if (result == 1)
            {
                Console.WriteLine("pen is expensive than pencil");
            }
            else if (result == -1)
            {
                Console.WriteLine("pen is less expensive than pensil");
            }
            else
            {
                Console.WriteLine("pen & pencil has equal price");
            }

        }
    }
    public class Product : IComparable
    {
        public int price;
        public string name;
        public Product(int price, string name)
        {
            this.price = price;
            this.name = name;
        }

        public int CompareTo(object obj)
        {

            
            Product p = (Product)obj; 
            
            if (this.price > p.price)
            {
                return 1;
            }
            else if (this.price < p.price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{price} -> {name}";
        }
    }



}
