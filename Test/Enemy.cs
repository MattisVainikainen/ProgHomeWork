using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Enemy
    {
        public void Shoot(Player p)
        {
            p.Health -= 500;
        }
    }
}
