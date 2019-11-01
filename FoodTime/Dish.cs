using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTime
{
    public class Dish
    {
        private string name { get; set; }
        List<Ingrediens> ingredienser;

        public Dish(string n)
        {
            n = name;
            ingredienser = new List<Ingrediens>();
        }

        public void AddIngredienser(Ingrediens ingrediens)
        {
            ingredienser.Add(ingrediens);
        }

    }
}
