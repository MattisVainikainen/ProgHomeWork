using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetOvning
{
    class User
    {
        private static int health;
        private static string name;

        public string Name
        {
            get { return name; }
        }
         
        public int Health
        {
            get { return health; }
            set
            {
                health = value;
            }
        }

        

        public User(int _health, string _name)
        {
            health = _health;
            name = _name;
        }
        public void Buy(int amount)
        {
            health -= amount;
            if (health <= 0)
            {
                health = 0;
            }
        }

        public void Sell(int amount)
        {
            health += amount;
        }
    }
}
