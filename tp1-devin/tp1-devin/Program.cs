using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1devin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable locales

            Int32 nbu, nbo;
            Random nbAlea = new Random();
            nbo = nbAlea.Next(0, 10);
            Console.WriteLine("Au joueur de choisir son nombre entre 0 et 10");
            nbu = Int32.Parse(Console.ReadLine());

            //Tant que le nombre de la machine n'est pas decouvert

            while (nbo != nbu)
            {
                if (nbo > nbu)
                {
                    Console.WriteLine("Le nb est trop petit");
                }
                else
                {
                    Console.WriteLine("trop grand");
                }
                Console.WriteLine("Au joueur de choisir son nombre entre 0 et 10");
                nbu = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("c'est gagner");
            Console.ReadKey();


        }
    }
}