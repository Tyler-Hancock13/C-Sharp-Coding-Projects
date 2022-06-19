using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    //Abstract means can never be instantiated
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public List<Player> Players { get { return _players; } set { _players = value; } }

        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        //Abstract method for other classes
        public abstract void Play();

        //Virtual method means method is inherited by class and can be overwritten
        public virtual void ListPlayers()
        {
            //Can have implementation
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
