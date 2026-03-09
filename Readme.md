C# | .NET | Console Application

![C#](https://img.shields.io/badge/language-C%23-blue)
![.NET](https://img.shields.io/badge/framework-.NET-purple)

# Deck Stats

Ett C# konsolprogram för att läsa textfiler och skriva ut statistik för Magic: The Gathering.

## Bakgrund

Detta var ett av mina första egna programmeringsprojekt utanför skoluppgifterna och fungerade som en introduktion till filhantering och databehandling i C#.

Programmet läser matchdata från `.txt` filer och sammanställer statistik.

Jag förde min statistik ganska rudimentärt i Google Keep och skrev statistiken på följande sätt:

```
The Locust God
G:II
W:II
L:
----------------
```

Varje lek hade sitt eget namn, hur många matcher som spelats, vinster och förluster. Men när det gått ett år
och man ska räkna ihop resultatet så drabbades jag av en utvecklares lathet, varför ska jag lägga 10 minuter på att handräkna detta
när jag kan spendera massa timmar på ett program som kan göra det åt mig.

## Teknologier

- C#
- .NET
- Filhantering
- LINQ

## Funktioner
- Läser statistik från `.txt` filer
- Sammanställer matcher, vinster och förluster
- Beräknar winrate
- Skriver ut resultatet i tabellformat

## Användning

Programmet är strikt med hur textfiler och struktur ska se ut. `.txt` ska namnges som mtg_stats2026.txt mtg_stats2027.txt etc. etc.

Filerna ska ligga i samma map som programmets `.exe` fil. Strukturen på statistiken behöver se ut som följande exempel:

```
Orvar
G:I
W:I
L:
----------------
Netheroi
G:II
W:
L:II
----------------
Dihada
G:II
W:
L:II
----------------
```
Resultatet skrivs sedan ut på följande vis:

```
==== mtg_stats2024.txt ====


  # Deck                                    Games     Wins     Losses        WR
--------------------------------------------------------------------------------
  1. Ixhel                                      2        1          1      50,0%
  2. Azlask                                     3        0          3       0,0%
  3. Necrobloom                                 5        3          2      60,0%
  4. Yuriko                                     1        0          1       0,0%
  5. Phenax                                     4        1          3      25,0%
  6. Necrons                                    6        0          6       0,0%
  7. Dihada                                     5        2          3      40,0%
  8. Ezrim Clue                                 4        1          3      25,0%
  9. Magnus Lucea Kane                          3        0          3       0,0%
 10. Kiora                                      6        1          5      16,7%
 11. Baba Lysaga                                6        1          5      16,7%
 12. Rakdos, Lord of Riots                      5        2          3      40,0%
 13. Go-Shintai                                 7        2          5      28,6%
 14. Trostani                                   4        1          3      25,0%
 15. Magnus                                     1        0          1       0,0%
 16. Elenda and Azor                            4        1          3      25,0%
 17. Wilhelt                                    7        1          6      14,3%
 18. Athreos                                    3        1          2      33,3%
 19. Sion of the Ur-Dragon/Ur-Dragon            3        1          2      33,3%
 20. Orvar                                      1        1          0     100,0%
 21. Titania                                    5        0          5       0,0%
 22. Shirei                                     3        1          2      33,3%
 23. Mill Horror                                2        0          2       0,0%
 24. Alibou                                     2        0          2       0,0%
 25. Kozilek                                    4        2          2      50,0%
 26. Octavia                                    2        1          1      50,0%
 27. Mirko Surveil                              2        0          2       0,0%
 28. Kenrith Monarch                            1        1          0     100,0%
 29. Sliver                                     2        0          2       0,0%
--------------------------------------------------------------------------------
Totalt                                        103       25         78      24,3%
--------------------------------------------------------------------------------
```

## Hur man kör programmet

1. Lägg `.txt` filer i samma mapp som programmets `.exe` fil
2. Se till att filerna följer formatet `mtg_stats2026.txt`
3. Kör programmet
4. Statistiken skrivs ut i konsolen

## Vad jag lärde mig

Detta projekt var en introduktion till:

- filhantering i C#
- att läsa och tolka textdata
- databehandling och statistik
- hur man strukturerar ett mindre program
