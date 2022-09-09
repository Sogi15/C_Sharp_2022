using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egyezoszamjegyek
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] szamsor =  new double[2];
            double szam1, szam2;
            do
            {
                Console.WriteLine("Írj be egy számot");
                szam1 = double.Parse(Console.ReadLine());
                szamsor[0] = szam1;
                Console.WriteLine("Írj be mégegy számot");
                szam2 = double.Parse(Console.ReadLine());
                szamsor[1] = szam2;
            } while (szamsor[0] != szamsor[1]);
            Console.WriteLine("Gratulálok az utolsó 2 szám megyezett");
            foreach (var index in szamsor)
            {
                Console.WriteLine(index);
            }
            Console.ReadKey();
        }
    }
}
