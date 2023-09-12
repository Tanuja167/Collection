using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Collection
{
    /*WAP to create jagged array, initialized data & display the details*/
    internal class Assign4
    {
        static void Main(string[] args)
        {
            int[][] ja = new int[3][];
            ja[0] = new int[] { 11,12,13,14};
            ja[1] = new int[] { 21, 22, 23};
            ja[2] = new int[] {31,32};

            

            for (int i=0; i<ja.Length; i++)
            {
                for(int j = 0; j < ja[i].Length; j++)
                {
                    Console.Write(ja[i][j]+" ");
                }
                Console.WriteLine();
            }


        }
    }
}
