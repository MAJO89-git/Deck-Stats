using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_Stats
{
    public static class StatsLoader
    {
        public static List<DeckStats> LoadStats(string path)
        {
            var decks = new List<DeckStats>();
            string[] lines = File.ReadAllLines(path);

            DeckStats current = null;

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("-"))
                {
                    if (current != null)
                    {

                        if (current.Wins + current.Losses != current.Games)
                        {
                            Console.WriteLine($"OBS: {current.DeckName} har G={current.Games}, men W+L={current.Wins + current.Losses}");
                        }

                        decks.Add(current);
                        current = null;
                    }
                    continue;
                }

                if (current == null)
                {
                    current = new DeckStats { DeckName = line.Trim() };
                }
                else
                {
                    string lower = line.ToLower();
                    string value = line.Contains(":") ? line.Split(':')[1].Trim() : "";

                    if (lower.StartsWith("g:") || lower.StartsWith("games:"))
                    {
                        current.Games = string.IsNullOrWhiteSpace(value) ? 0 : RomanToInt(value);
                    }
                    else if (lower.StartsWith("w:") || lower.StartsWith("wins:"))
                    {
                        current.Wins = string.IsNullOrWhiteSpace(value) ? 0 : RomanToInt(value);
                    }
                    else if (lower.StartsWith("l:") || lower.StartsWith("losses:"))
                    {
                        current.Losses = string.IsNullOrWhiteSpace(value) ? 0 : RomanToInt(value);
                    }
                }
            }


            if (current != null)
            {
                if (current.Wins + current.Losses != current.Games)
                {
                    Console.WriteLine($"OBS: {current.DeckName} har G={current.Games}, men W+L={current.Wins + current.Losses}");
                }
                decks.Add(current);
            }

            return decks;
        }

        public static int RomanToInt(string roman)
        {
            var map = new Dictionary<char, int>
            {
             {'I', 1}, {'V', 5}, {'X', 10}
            };

            if (string.IsNullOrWhiteSpace(roman))
                return 0;


            roman = roman.Replace(" ", "").Trim();

            int total = 0;
            int prev = 0;

            foreach (char c in roman.Reverse())
            {
                if (!map.ContainsKey(c))
                {
                    Console.WriteLine($"Varning: Ogiltigt tecken '{c}' i romerskt tal '{roman}'. Tolkas som 0.");
                    return 0;
                }

                int value = map[c];
                if (value < prev)
                    total -= value;
                else
                {
                    total += value;
                    prev = value;
                }
            }

            return total;
        }

    }
}
