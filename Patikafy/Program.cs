using System;

namespace Patikafy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Artist> items = new List<Artist> // creating the list of objects
            {
                new Artist{ NameLastname = "Ajda Pekkan", Genre="Pop", Debut=1968, Sold = 20000000 },
                new Artist{ NameLastname = "Sezen Aksu", Genre="Türk Halk Müziği / Pop", Debut=1971, Sold = 100000000 },
                new Artist{ NameLastname = "Funda Arar", Genre="Pop", Debut=1999, Sold = 3000000 },
                new Artist{ NameLastname = "Sertap Erener", Genre="Pop", Debut=1994, Sold = 50000000 },
                new Artist{ NameLastname = "Sıla", Genre="Pop", Debut=2009, Sold = 3000000 },
                new Artist{ NameLastname = "Serdar Ortaç", Genre="Pop", Debut=1994, Sold = 10000000 },
                new Artist{ NameLastname = "Tarkan", Genre="Pop", Debut=1992, Sold = 40000000 },
                new Artist{ NameLastname = "Hande Yener", Genre="Pop", Debut=1999, Sold = 20000000 },
                new Artist{ NameLastname = "Hadise", Genre="Pop", Debut=2005, Sold = 5000000 },
                new Artist{ NameLastname = "Gülben Ergen", Genre="Pop", Debut=1968, Sold = 20000000 },
                new Artist{ NameLastname = "Neşet Ertaş", Genre="Pop", Debut=1960, Sold = 2000000 },
            };

            var artistWithS = items.Where(x => x.NameLastname.Substring(0, 1) == "S"); //all artists with the first letter 's'
            var salesOver10M = items.Where(x => x.Sold > 10000000); //artists with sales over 10M
            var debutBefore2000 = items.Where(x => x.Debut < 2000); // artists who entered the industry before 2000
            Artist ArtistSellsMost =(items.Where(x => x.Sold == items.Max(x => x.Sold))).First(); //the artist with the most sales
            var newestOldestDebut = items.Where(x => x.Debut == items.Max(x => x.Debut) || x.Debut == items.Min(x => x.Debut)); //newest and oldest debuted artists
        }
    }
}