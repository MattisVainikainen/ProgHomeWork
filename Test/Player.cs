using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Player
    {
        public int Health { get; set; }

        public int Money { get; set; }

        public void BuyingArmor(Player p)
        {

            p.Money -= 500;
        }
    }
}
