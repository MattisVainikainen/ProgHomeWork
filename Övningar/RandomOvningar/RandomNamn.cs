using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.RandomOvningar
{
    class RandomNamn
    {
        public void RandomNames()
        {
            Console.WriteLine("Drums please!! Lets do this!");
            Console.ReadLine();

            

            do
            {

                List<string> randomNamn = new List<string>();
                randomNamn.Add("Lollo");
                randomNamn.Add("Mikael");
                randomNamn.Add("Mattis");
                randomNamn.Add("Andreas");
                randomNamn.Add("Alexander");
                randomNamn.Add("Huy");
                randomNamn.Add("Jonathan");
                randomNamn.Add("Daniel");
                randomNamn.Add("André"); 


                List<string> randomGrupp = new List<string>();
                randomGrupp.Add("Projekt Grupp Salvadores");
                randomGrupp.Add("Projekt Grupp Impossible possible");

                for (int i = 0; i < randomNamn.Count; i++)
                {

                    Random r = new Random();
                    int rand = r.Next(randomGrupp.Count);
                    Console.WriteLine(randomNamn[i] + " tillhör nu " + randomGrupp[rand]);
                    
                    Console.ReadLine();
                    
                }
            } while (true);
        }
        
    }
}
