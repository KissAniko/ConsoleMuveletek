using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMuveletek
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //a)
            List<Kifejezes> kifejezesek = new List<Kifejezes>();

            var sorok = File.ReadAllLines("kifejezesek.txt");

            foreach (var s in sorok)
            {
                var mezok = s.Split();
                kifejezesek.Add(new Kifejezes(int.Parse(mezok[0]), mezok[1], int.Parse(mezok[2])));
            }
            Console.WriteLine("Beolvasás készen van!");

            //b) LINQ
            List<Kifejezes> kifejezesek2 = File.ReadAllLines("kifejezesek.txt")
                .Select(sor => new Kifejezes(sor)).ToList();

            int kifejezesekSzama = kifejezesek.Count;
            Console.WriteLine("A kifejezések száma: " + kifejezesekSzama);

//--------------------------------------------------------------------------------------------

             int eredmeny = kifejezesek.Count(x => x.Muvelet == "mod");
            Console.WriteLine($"3. feladat: Kifejezések maradékos osztással: {eredmeny}");


            //hagyományos megoldás:

            /*   int db = 0;
                 foreach (var item in kifejezesek)
               {
                   if (item.Muvelet == "mod")
                  {
                       db++;
                   }
               }
            */
//--------------------------------------------------------------------------------------------

            bool eredmenyBool = kifejezesek.Any(x => x.OperandusBal % 10 == 0 && x.OperandusJobb % 10 == 0);
            Console.WriteLine($"4. feladat: {(eredmenyBool ? "Van" : "Nincs")} ilyen kifejezés");

//---------------------------------------------------------------------------------------------

         // Készítsen statisztikát az összeadás (+), kivonás (-), szorzás (*), valós osztás (/),
         // egész osztás (div) és maradékos osztás (mod) operátorokat tartalmazó kifejezések számáról.

               Console.WriteLine("5. feladat: Statisztika");
            kifejezesek.Where(x => ValosOperator(x.Muvelet))
                       .GroupBy(x => x.Muvelet)
                       .ToList()
                       .ForEach(x => Console.WriteLine($"\t{x.Key} -> {x.Count()} db"));
        }

        private static bool ValosOperator(string muvelet)
        {
            throw new NotImplementedException();
        }
    }
}
