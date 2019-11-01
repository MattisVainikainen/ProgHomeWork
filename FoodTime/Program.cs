using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Dish Pancakes = new Dish("Pancakes");

            Pancakes.AddIngredienser(new Ingrediens("Ägg"));
            Pancakes.AddIngredienser(new Ingrediens("Mjöl"));
            Pancakes.AddIngredienser(new Ingrediens("Socker"));
            Pancakes.AddIngredienser(new Ingrediens("VeteMjöl"));
            
            Dish Pizza = new Dish("Pizza");
            Pizza.AddIngredienser(new Ingrediens("Vetemjöl"));
            Pizza.AddIngredienser(new Ingrediens("Salami"));
            Pizza.AddIngredienser(new Ingrediens("Skinka"));
            Pizza.AddIngredienser(new Ingrediens("Ost"));

            Console.WriteLine($"Maträtt nr 1: {Pizza}");
            Console.WriteLine($"Maträtt nr 2: {Pancakes}");
            Console.ReadKey();
        }
    }
}
