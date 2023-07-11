using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iebumrable
{
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
            return $"{name}-->{runs}";
        }
    }
    public class Team:IEnumerable
    {
        Player[] players;
        public Team()
        {
            players = new Player[3];
            players[0] = new Player(12000, "Sachin");
            players[1] = new Player(11000, "Dhoni");
            players[2] = new Player(10000, "Virat");
        }
        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }
    }
}
