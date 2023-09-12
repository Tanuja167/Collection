using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Collection
{
    internal class Ienumerable1
    {
        static void Main(string[] args)
        {
            Team t = new Team();
            foreach(Player item in t)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Player
    {
        private int runs;
        private string name;

        public Player(int runs, string name)
        {
            this.runs = runs;
            this.name = name;
        }
        public override string ToString()
        {
            return $"{runs} - {name}";
                
        }
        
    }
    public class Team : IEnumerable
    {
        private Player[] pl;
        public Team()
        {
            pl = new Player[3]
            {
                new Player(100, "ABCD"),
                new Player(200, "WXYZ"),
                new Player(300, "STQR")
            };
        }
        public IEnumerator GetEnumerator()
        {
            return pl.GetEnumerator();
        }

    }
}
