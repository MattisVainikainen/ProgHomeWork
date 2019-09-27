using System;
using System.Collections;
using System.Collections.Generic;

namespace ProgHomeWork.Övningar.Collections
{
    class CollectionOvning
    {
        public void Collection()
        {
            ArrayList medical = new ArrayList();
            medical.Add("Mattis");
            medical.Add(10);
            medical.Add("Alice");
            medical.Add(41.4f);

            foreach (object item in medical)
            {
                Console.WriteLine("----------------");
                Console.WriteLine($"Items: {item}");


            }
            Console.WriteLine("----------------");
            Console.ReadLine();
        }

        public void CollectionGenericExample()
        {
            Dictionary<string, int> Grocerys = new Dictionary<string, int>();
            Grocerys.Add("Äpple", 10);
            Grocerys.Add("Päron", 14);

            List<int> Grocery = new List<int>();
            Grocery.Add(10);
            Grocery.Add(40);
            Grocery.Add(80);
            Grocery.Add(45);

            int sum = 0;
            foreach (int g in Grocery)
            {
                sum += g;
                Console.WriteLine(g);
                Console.WriteLine();
            }
            Console.WriteLine($"Total: {sum}");

        }

        public static void RunCollection()
        {
            CollectionOvning collection = new CollectionOvning();
            collection.Collection();

            CollectionOvning collection1 = new CollectionOvning();
            collection1.CollectionGenericExample();
        }
    }
}
