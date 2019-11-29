using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTenta1
{
    class Ovning8
    {
        public void Ovn8()
        {

            //Skapar 2 arrays varav vi kopierar mellersta indexplatsen till en ny plats i array b.
            int[] a = new int[5] { 3, -5, 1, -13, 20 };
            int[] b = new int[5];


            //Felaktig lösning men funkar ändå =)
            //Försökte söka på hur man kunde ange att index platsen skulle fyllas ut på samma gång men hittade ej. 
            //Fick lösa det såhär hehe

            //Anger vilken array vi skall kopiera och vilken indexplats vi vill kopiera.
            //Vi anger sedan vilken array den skall kopieras till och vilken indexplats.
           
            Array.Copy(a, 2, b, 0, 1);
            Array.Copy(a, 2, b, 1, 1);
            Array.Copy(a, 2, b, 2, 1);
            Array.Copy(a, 2, b, 3, 1);
            Array.Copy(a, 2, b, 4, 1);

            foreach (var number in b)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();










        }


        public static void PrintOvning8()
        {
            Ovning8 Ovn8 = new Ovning8();
            Ovn8.Ovn8();
        }
    }
}
