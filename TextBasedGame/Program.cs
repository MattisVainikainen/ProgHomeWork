using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(70, 200, 0);
            Player.ChooseName();
            Player.ShowStatus();

            Battle.Fight(player);
            Player.ShowStatus();

            Battle.Heal(player);
            Player.ShowStatus();

            Battle.Fight(player);
            Player.ShowStatus();

            Console.ReadKey();

        }
    }
}
