using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Övning 1 ");
            Console.WriteLine("2) Övning 2 ");
            Console.WriteLine("3) Övning 3 ");
            Console.WriteLine("4) Övning 4 ");
            Console.WriteLine("4) Övning 5 ");
            Console.WriteLine("4) Övning 6 ");
            Console.WriteLine("7) Övning 7 ");
            Console.WriteLine("8) Övning 8 ");
            Console.WriteLine("9) Övning 9 ");
            Console.WriteLine("10) Övning 10 ");
            Console.WriteLine("11) Övning 11 ");
            Console.WriteLine("12) Övning 12 ");
            Console.WriteLine("13) Övning 13 ");
            Console.WriteLine("14) Övning 14 ");
            Console.WriteLine("15) Övning 15 ");
            Console.WriteLine("16) Övning 16 ");
            Console.WriteLine("17) Övning 17 ");
            Console.WriteLine("18) Övning 18 ");
            Console.WriteLine("19) Övning 19 ");
            Console.WriteLine("20) Övning 20 ");
            Console.WriteLine();
            Console.Write("Välj Övning: ");
            int menuVal = Convert.ToInt32(Console.ReadLine());

            switch(menuVal)
            {
                #region Övning 1-5
                case 1:
                    Övningar.IfSatser.Ovning1 Ovning1 = new Övningar.IfSatser.Ovning1();
                    Ovning1.Print();
                    break;

                case 2:
                    Övningar.IfSatser.Ovning2 Ovning2 = new Övningar.IfSatser.Ovning2();
                    Ovning2.PrintDouble();
                    break;

                case 3:
                    Övningar.IfSatser.Ovning3 Ovning3 = new Övningar.IfSatser.Ovning3();
                    Ovning3.PrintEvenNumber();
                    break;

                case 4:
                    Övningar.IfSatser.Ovning4 Ovning4 = new Övningar.IfSatser.Ovning4();
                    Ovning4.PrintEvenOrOddNumber();
                    break;

                case 5:
                    Övningar.IfSatser.Ovning5 Ovning5 = new Övningar.IfSatser.Ovning5();
                    Ovning5.PrintJamntDelatMedtal2();
                    break;
                #endregion
                #region Övning 6-10
                case 6:
                    Övningar.IfSatser.Ovning6 Ovning6 = new Övningar.IfSatser.Ovning6();
                    Ovning6.Print();
                    break;

                case 7:
                    Övningar.IfSatser.Ovning7 Ovning7 = new Övningar.IfSatser.Ovning7();
                    Ovning7.PrintKvot();
                    break;

                case 8:
                    Övningar.IfSatser.Ovning8 Ovning8 = new Övningar.IfSatser.Ovning8();
                    Ovning8.PrintXOchY();
                    break;

                case 9:
                    Övningar.IfSatser.Ovning9 Ovning9 = new Övningar.IfSatser.Ovning9();
                    Ovning9.Print();
                    break;

                case 10:
                    Övningar.IfSatser.Ovning10 Ovning10 = new Övningar.IfSatser.Ovning10();
                    Ovning10.Print();
                    break;
                #endregion
                #region Övning 11-15
                case 11:
                    Övningar.IfSatser.Ovning11 Ovning11 = new Övningar.IfSatser.Ovning11();
                    Ovning11.Print();
                    break;

                case 12:
                    Övningar.IfSatser.Ovning12 Ovning12 = new Övningar.IfSatser.Ovning12();
                    Ovning12.Print();
                    break;

                case 13:
                    Övningar.IfSatser.Ovning13 Ovning13 = new Övningar.IfSatser.Ovning13();
                    Ovning13.Print();
                    break;

                case 14:
                    Övningar.IfSatser.Ovning14 Ovning14 = new Övningar.IfSatser.Ovning14();
                    Ovning14.Print();
                    break;

                case 15:
                    Övningar.IfSatser.Ovning15 Ovning15 = new Övningar.IfSatser.Ovning15();
                    Ovning15.Print();
                    break;
                #endregion
                case 16:
                    Övningar.IfSatser.Ovning16 Ovning16 = new Övningar.IfSatser.Ovning16();
                    Ovning16.Print();
                    break;

                case 17:
                    Övningar.IfSatser.Ovning17 Ovning17 = new Övningar.IfSatser.Ovning17();
                    Ovning17.Print();
                    break;

                case 18:
                    Övningar.IfSatser.Ovning18 Ovning18 = new Övningar.IfSatser.Ovning18();
                    Ovning18.Print();
                    break;

                case 19:
                    Övningar.IfSatser.Ovning19 Ovning19 = new Övningar.IfSatser.Ovning19();
                    Ovning19.Print();
                    break;

                case 20:
                    Övningar.IfSatser.Ovning20 Ovning20 = new Övningar.IfSatser.Ovning20();
                    Ovning20.Print();
                    break;


                default:
                    Console.WriteLine("Välj ibland menyn: ");
                    break;
            }
            
              
        }
    }
}
