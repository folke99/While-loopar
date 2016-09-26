using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            /*
            int n = 0;
            while (n++ < 100)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
            */

            //Övning 2
            /*
            Console.WriteLine("Skriv in dit lösenord:");


            bool n = true;
            while (n)
            {
                string password = Console.ReadLine();

                if (password == "password")
                {
                    Console.WriteLine("Välkommen");
                    n = false;
                }
                else
                {
                    Console.WriteLine("Försök igen");
                }
            }
            Console.ReadKey();
            */
            //Övning 2.1
            /*
            int i = 1;
            while (i++ <= 100)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            */
            //Övning 2.2
            /*
            int i = 10;
            while (i-- >= 1)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            */
            //Övning 2.3
            /*
            while (true)
            {
                Console.WriteLine("INFINITYYYYY!!!!!!11");
            }
            */
            //Övning 2.4
            /*
            Console.WriteLine("Gissa ett tal mellan 1 och 100: ");
            Random rnd = new Random();
            bool villkår = true;
            int tal = rnd.Next(100);
            int i = 0;
            while (villkår)
            {
                int gissning = int.Parse(Console.ReadLine());
                if (gissning < tal)
                {
                    Console.WriteLine("För lågt");
                }

                else if (gissning > tal)
                {
                    Console.WriteLine("För högt");
                }

                else
                {
                    Console.WriteLine("Det tog " + i + " försök!");
                    villkår = false;
                }
                i++;

            }
            Console.ReadKey();
            */
            //Övning 2.5
            /*

            Console.WriteLine("1k lax fibbonacci!");            
            int z = 0;
            int y = 1;
            Console.Write("Fibbonacci blir: ");
            bool i = true;
            while (i)
            {
                int nyttVärde = z;
                z = y;
                y = nyttVärde + y;
                if (y>1000000)
                {                   
                    i = false;
                }
                Console.Write(z + " ");
            }
            Console.ReadKey();
            */
            //Övning 2.6
            /*
            Console.WriteLine("Pengar på kontot:");
            double pengar = double.Parse(Console.ReadLine());
            Console.WriteLine("Ränta");
            double ränta = double.Parse(Console.ReadLine());
            Console.WriteLine("Mål");
            int mål = int.Parse(Console.ReadLine());

            int i = 0;
            double y = pengar;
            while (y < mål)
            {
                y = ((ränta/100) + 1) * y;
                
                i++;
            }

            Console.WriteLine(i + "År innan saldot når: " + y);
            Console.ReadKey();
            */
            //Övning 2.7
        }//Main
    }//class
}
