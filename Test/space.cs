using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class space
    {
        public void space1()
        {
            var p1 = new Player();
            p1.Health = 5000;
            p1.Money = 3000;
            Console.WriteLine($"Money: {p1.Money}");
            Console.WriteLine($"Health: { p1.Health }");
            Console.ReadLine();

            var enemy = new Enemy();
            Console.WriteLine("Enemy shooting me");
            Console.ReadLine();
            enemy.Shoot(p1);

            Console.WriteLine($"Health after being shot: {p1.Health}");
            Console.WriteLine($"Buying armor for 500.");
            Console.ReadLine();
            p1.BuyingArmor(p1);
            Console.WriteLine($"Current money: {p1.Money}");
            Console.ReadLine();
        }

        public static void RunSpace()
        {
            space s = new space();
            s.space1();
        }
        
    }
}
