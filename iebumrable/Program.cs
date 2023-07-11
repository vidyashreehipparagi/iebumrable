using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iebumrable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team india= new Team();
            foreach(Player p in india)
            {
                Console.WriteLine(p);
            }
        }
    }
}
