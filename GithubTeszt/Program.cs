using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubTeszt
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdm = new Random();
            Console.WriteLine("40db véletlenszám!");
            for (int i = 0; i <= 40; i++)
            {
                Console.Write($"{rdm.Next(-100,100)} ");
            }
            Console.ReadKey();
        }
    }
}
