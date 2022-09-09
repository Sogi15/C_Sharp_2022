using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írd be a Celsius fokot, hogy átváltsuk Fahrenheitbe!");
            double celsius;
            int hibak = 0;
            do
            {
                if(hibak > 1)
                {
                    Console.WriteLine("Hibás adatot adtál be!\nKérlek próbáld újra!");
                }
                hibak++;
            } while (!double.TryParse(Console.ReadLine(), out celsius));
            Console.WriteLine($"Az átváltás eredménye: {Math.Round(celsius*1.8000+32,2)} Fahrenheit");
            Console.ReadKey();
        }
    }
}
