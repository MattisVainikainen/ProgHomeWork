using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Movies();
            

            
            Console.ReadLine();
        }

        public static void Movies()
        {
            RentMovies Movie001 = new RentMovies("Hero", "G");
            RentMovies Movie002 = new RentMovies("Last Stand", "G");
            RentMovies Movie003 = new RentMovies("Lost World", "PG");
            RentMovies Movie004 = new RentMovies("Counter Z", "R");

            Dictionary<string, string> AllMovies = new Dictionary<string, string>();
            Dictionary<string, string> YourMovies = new Dictionary<string, string>();


            AllMovies.Add(Movie001.name, Movie001.Rating);
            AllMovies.Add(Movie002.name, Movie002.Rating);
            AllMovies.Add(Movie003.name, Movie003.Rating);
            AllMovies.Add(Movie004.name, Movie004.Rating);

            do
            {
                Console.WriteLine("Rent a movie!");
                Console.WriteLine();
                Console.WriteLine("_____________________________");
                foreach (var item in AllMovies)
                {
                    
                    Console.WriteLine($"{item}");
                }
                Console.WriteLine("_____________________________");
                Console.WriteLine();
                Console.WriteLine("5) Check your movies ");
                Console.WriteLine();
                Console.Write("Choose option: ");
                int ChooseMovie = int.Parse(Console.ReadLine());

                switch (ChooseMovie)
                {
                    case 1:
                        AllMovies.Remove(Movie001.name);
                        AllMovies.Remove(Movie001.Rating);
                        YourMovies.Add(Movie001.name, Movie001.Rating);
                        Console.Clear();
                        break;

                    case 2:
                        AllMovies.Remove(Movie002.name);
                        AllMovies.Remove(Movie002.Rating);
                        YourMovies.Add(Movie002.name, Movie002.Rating);
                        Console.Clear();
                        break;

                    case 3:
                        AllMovies.Remove(Movie003.name);
                        AllMovies.Remove(Movie003.Rating);
                        YourMovies.Add(Movie003.name, Movie003.Rating);
                        Console.Clear();
                        break;

                    case 4:
                        AllMovies.Remove(Movie004.name);
                        AllMovies.Remove(Movie004.Rating);
                        YourMovies.Add(Movie004.name, Movie004.Rating);
                        Console.Clear();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine($"Your movies: ");
                        foreach (var movie in YourMovies)
                        {
                            Console.WriteLine(movie);
                        }
                        break;

                    default:
                        Console.WriteLine("Välj en film som finns..");
                        Console.Clear();
                        break;
                } 
            } while (true);
            
        }
    }
}
