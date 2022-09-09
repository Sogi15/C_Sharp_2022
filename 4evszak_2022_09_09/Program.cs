using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4evszak_2022_09_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérlek írd be egy hónap számát!");
            int honapszama, hibasadat = 0;
            string evszak = "";
            int[] honapok = new int[] {1,2,3,4,5,6,7,8,9,10,11,12};
            do
            {
                if(hibasadat > 0)
                {
                    Console.WriteLine("Kérlek helyes adatokat írj be! A hónapok száma 1-12 lehet!\nÍrd be újra a számot!");
                }
                hibasadat++;
            } while (!int.TryParse(Console.ReadLine(), out honapszama) || honapszama > 12 || honapszama < 1);
            if (honapszama == honapok[0] || honapszama == honapok[1] || honapszama == honapok[11])
            {
                evszak = "Tél";
            }
            else if (honapszama == honapok[2] || honapszama == honapok[3] || honapszama == honapok[4])
            {
                evszak = "Tavasz";
            }
            else if (honapszama == honapok[5] || honapszama == honapok[6] || honapszama == honapok[7])
            {
                evszak = "Nyár";
            }
            else if (honapszama == honapok[8] || honapszama == honapok[9] || honapszama == honapok[10])
            {
                evszak = "Ősz";
            }
            Console.WriteLine($"A beírt adatok alapján az évszak: {evszak}\nBeírt hónap: {honapszama}");
            Console.ReadKey();
        }
    }
}
