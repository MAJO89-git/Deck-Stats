using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Stats
{
    public class DeckStats
    {
        public string DeckName { get; set; }
        public int Games { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }

        public double Winrate => Games > 0 ? (double)Wins / Games * 100 : 0;

    }
}
