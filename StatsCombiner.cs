using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Stats
{
    public static class StatsCombiner
    {
        public static List<DeckStats> CombineDecks(List<DeckStats> allStats)
        {
            return allStats
                .GroupBy(d => d.DeckName)
                .Select(g => new DeckStats
                {
                    DeckName = g.Key,
                    Games = g.Sum(d => d.Games),
                    Wins = g.Sum(d => d.Wins),
                    Losses = g.Sum(d => d.Losses)
                })
                .OrderBy(d => d.DeckName)
                .ToList();
        }
    }
}

