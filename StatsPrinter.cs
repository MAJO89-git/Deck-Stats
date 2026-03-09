using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Stats
{
    public static class StatsPrinter
    {
        public static void PrintStats(string title, List<DeckStats> stats)
        {
            Console.WriteLine($"\n==== {title} ====\n");

            int totalGames = stats.Sum(d => d.Games);
            int totalWins = stats.Sum(d => d.Wins);
            int totalLosses = stats.Sum(d => d.Losses);
            double totalWinrate = totalGames > 0 ? (double)totalWins / totalGames * 100 : 0;
            int index = 1;
            int maxNameLength = 35;


            Console.WriteLine();
            Console.WriteLine($"{"#",3} {"Deck",-36} {"Games",8} {"Wins",8} {"Losses",10} {"WR",9}");
            Console.WriteLine(new string('-', 80));

            foreach (var deck in stats)
            {

                string name = deck.DeckName.Length > maxNameLength
                    ? deck.DeckName.Substring(0, maxNameLength - 3) + "..." : deck.DeckName;

                Console.WriteLine($"{index,3}. {name,-35} {deck.Games,8} {deck.Wins,8} {deck.Losses,10} {deck.Winrate,9:F1}%");
                index++;
            }

            Console.WriteLine(new string('-', 80));
            Console.WriteLine($"{"Totalt",-40} {totalGames,8} {totalWins,8} {totalLosses,10} {totalWinrate,9:F1}%");
            Console.WriteLine(new string('-', 80));
        }
    }
}
