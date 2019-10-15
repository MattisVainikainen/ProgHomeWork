using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Characters Hero01 = new Characters("Grouz", "Dark Phoenix", 20, 150);
            Characters Hero02 = new Characters("Fierlo", "Angel", 1, 1000);
            Characters Hero03 = new Characters("Lolita", "Troll", 60, 10);
            Characters Hero04 = new Characters("Bonkerz", "Dark", 20, 350);


            Console.ReadKey();

        }
    }
}
