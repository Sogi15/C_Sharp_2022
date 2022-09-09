using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csillagjegyek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérlek írd be a hónap számát!");
            int honapszama, honaphiba = 0, napszama, naphiba = 0, napok;
            int[] honapok = new int[] {31,28,31,30,31,30,31,31,30,31,30,31};
            DateTime kos = new DateTime(2022,3,21);
            DateTime bika = new DateTime(2022, 4, 21);
            DateTime ikrek = new DateTime(2022, 5, 22);
            DateTime rak = new DateTime(2022, 6, 22);
            DateTime oroszlan = new DateTime(2022, 7, 23);
            DateTime szuz = new DateTime(2022, 8, 24);
            DateTime merleg = new DateTime(2022, 9, 23);
            DateTime skorpio = new DateTime(2022, 10, 24);
            DateTime nyilas = new DateTime(2022, 11, 23);
            DateTime bak = new DateTime(2022, 12, 22);
            DateTime vizonto = new DateTime(2023, 1, 21);
            DateTime halak = new DateTime(2023, 2, 20);

            string csillagjegy = "";
            do
            {
                if (honaphiba > 0)
                {
                    Console.WriteLine("Kérlek helyes adatokat írj be! A hónapok száma 1-12 lehet!\nÍrd be újra a számot!");
                }
                honaphiba++;
            } while (!int.TryParse(Console.ReadLine(), out honapszama) || honapszama > 12 || honapszama < 1);
            Console.WriteLine("Kérlek add meg a napok számát!");
            do
            {
                napok = honapok[honapszama-1];
                if (naphiba > 0)
                {
                    Console.WriteLine("Kérlek helyes adatokat írj be!\nPróbáld újra!");
                }
                naphiba++;
            } while (!int.TryParse(Console.ReadLine(), out napszama) || napszama > napok || napszama < 1);
            DateTime datum = new DateTime(2022, honapszama, napszama);
            if (datum>=kos && datum<bika){csillagjegy = "Kos";}
            else if (datum >= bika && datum <= ikrek) { csillagjegy = "Bika"; }
            else if (datum >= ikrek && datum <= rak) { csillagjegy = "Ikrek"; }
            else if (datum >= rak && datum <= oroszlan) { csillagjegy = "Rák"; }
            else if (datum >= oroszlan && datum <= szuz) { csillagjegy = "Oroszlán"; }
            else if (datum >= szuz && datum <= merleg) { csillagjegy = "Szűz"; }
            else if (datum >= merleg && datum <= skorpio) { csillagjegy = "Mérleg"; }
            else if (datum >= skorpio && datum <= nyilas) { csillagjegy = "Skorpió"; }
            else if (datum >= nyilas && datum <= bak) { csillagjegy = "Nyilas"; }
            else if (datum >= bak && datum <= vizonto) { csillagjegy = "Bak"; }
            else if (datum >= vizonto && datum <= halak) { csillagjegy = "Vizöntő"; }
            else if (datum >= halak) { csillagjegy = "Halak"; }

            Console.WriteLine($"Gratulálok a csillagjegyed: {csillagjegy}");
            Console.ReadKey();
        }
    }
}
