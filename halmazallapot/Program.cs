using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halmazallapot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írd be kérlek a víz hőmérsékletét");
            double homerseklet;
            string halmazallapot = "";
            int hibak = 0;
            do
            {
                if (hibak > 0)
                { Console.WriteLine("Kérlek helyesen add meg az adatokat! Csak számot fogadok el!\nPróbád újra"); }
                hibak++;
            } while (!double.TryParse(Console.ReadLine(), out homerseklet));
            if(homerseklet < 0 )
            {
                halmazallapot = "Jég";
            }
            else if(homerseklet > 100)
            {
                halmazallapot = "Gőz";
            }
            else
            {
                halmazallapot = "Folyékony";
            }
            Console.WriteLine($"Az általad beírt adatok alapján a víz halmazállapota: {halmazallapot}\nHőmérséklete: {homerseklet}°C");
            Console.ReadKey();
        }
    }
}
