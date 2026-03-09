using System;
using System.Collections;
using System.IO;
using System.Linq;

namespace Deck_Stats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var files = Directory.GetFiles(Directory.GetCurrentDirectory(), "mtg_stats*.txt").OrderBy(f => f).ToArray();

            if (files.Length == 0)
            {
                Console.WriteLine("Ingen stats-fil hittades i mappen.");
                return;
            }

            var allStats = new List<DeckStats>();

            foreach (var file in files)
            {
                var stats = StatsLoader.LoadStats(file);
                StatsPrinter.PrintStats(Path.GetFileName(file), stats); 
                allStats.AddRange(stats);
            }

            
            var combined = StatsCombiner.CombineDecks(allStats);
            StatsPrinter.PrintStats("Total (alla år)", combined);

            Console.ReadLine();
        }






    }
}
