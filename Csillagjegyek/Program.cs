using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csillagjegyek
{
    class Program
    {
        internal class Csillagjegyek
        {
            /* szöveg	kezd	év napja	jegy
             * Vízöntő:Január 21.- Február 19.	    01-21	20	    Vízöntő
             * Halak: Február 20.-  Március 20.	    02-20	49	    Halak
             * Kos: Március 21.- Április 20.	    03-21	80	    Kos
             * Bika:  Április 21.- Május 21.	    04-21	110	    Bika
             * Ikrek:Május 22.- Június 21.	        05-22	141	    Ikrek
             * Rák:Június 22.- Július 22. 	        06-22	171	    Rák
             * Oroszlán: Július 23.- Augusztus 23.	07-23	202	    Oroszlán
             * Szűz: Augusztus 24.- Szeptember 22.	08-24	233	    Szűz
             * Mérleg:Szeptember 23. - Október 23.	09-23	262	    Mérleg
             * Skorpió:Október 24.- November 22.	10-24	293	    Skorpió
             * Nyilas:November 23.- December 21.	11-23	322	    Nyilas
             * Bak:December 22.- Január 20.	        12-22	351	    Bak
             */

            static int kapottNap;
            static int kapottHonap;
            static void Main(string[] args)
            {
                Horoszkop horoszkop = new Horoszkop();
                
                //-- bekerjük a honapot
                kapottHonap = egeszSzamBekerese("Melyik hónap?", 1, 12);
                //-- bekerjük a napot
                kapottNap = egeszSzamBekerese("Melyik nap?", 1, 31);
                //-- meghatározzuk az éven belüli napszámot
                int aNapSorszama = new DateTime(DateTime.Now.Year, kapottHonap, kapottNap).DayOfYear;

                //-- megadjuk a csillagjegyet
                string csillagjegy = DatumToCsillagjegy(kapottHonap, kapottNap);

                Console.WriteLine($"{kapottHonap} hónap {kapottNap} napja a {csillagjegy} csillagjegybe tartozik");
                //-- leállítjuk a programot
                Console.WriteLine("\nProgram vége!");
                Console.ReadKey();
            }

            //private static string DatumToCsillagjegy(int kapottHonap, int kapottNap)
            //{
            //    int hc = 0;
            //    DateTime[] date = new DateTime[1] { new DateTime(2022, kapottHonap, kapottNap), };
            //    //--tömb(ök)
            //    DateTime[] dates = new DateTime[13] {
            //    new DateTime(2021, 12, 31),
            //    new DateTime(2022, 01, 20),
            //    new DateTime(2022, 02, 19),
            //    new DateTime(2022, 03, 21),
            //    new DateTime(2022, 04, 20),
            //    new DateTime(2022, 05, 21),
            //    new DateTime(2022, 06, 22),
            //    new DateTime(2022, 07, 23),
            //    new DateTime(2022, 08, 23),
            //    new DateTime(2022, 09, 23),
            //    new DateTime(2022, 10, 23),
            //    new DateTime(2022, 11, 22),
            //    new DateTime(2022, 12, 22) };
            //    String[] jegyek = new String[13]{
            //"Bak","Vízöntő","Halak","Kos",
            //"Bika","Ikrek","Rák",
            //"Oroszlán","Szűz","Mérleg",
            //"Skorpió","Nyilas","Bak" };
            //    //--ciklus
            //    for (int i = 0; i < dates.Length; i++)
            //    {
            //        if (dates[i] < date[0])
            //        {
            //            hc++;
            //        }
            //        else
            //        {
            //            i = 32;
            //        }
            //    }
            //    //-- program vég
            //    //Console.WriteLine("Te a {0} csillag jegyében születét.", jegyek[hc - 1]);

            //    return jegyek[hc - 1];
            //}

            private static int egeszSzamBekerese(string szoveg, int tol, int ig)
            {
                int egeszSzam = 0;
                int bekeresekSzama = 0;
                Console.WriteLine(szoveg);
                do
                {
                    if (bekeresekSzama > 0)
                    {
                        Console.WriteLine("Nem megfellő érték!");
                    }
                    bekeresekSzama++;
                } while (!int.TryParse(Console.ReadLine(), out egeszSzam) || egeszSzam < tol || egeszSzam > ig);
                return egeszSzam;
            }
        }
    }
}
