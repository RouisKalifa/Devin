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
        static int SaisieNombre()
        {
            int nb;
            while (!Int32.TryParse(Console.ReadLine(), out nb))
            {
                Console.WriteLine("vous devez entrer un nombre entier");
            }
            return nb;
        }
        static void Main(string[] args)
        {
            //variable locales
            Int32 nbu, nbo,nbEssai ;
            char reponse;


            bool success;
            bool success2; 

            const int NBCOUP = 5;
            do
            {
                Random nbAlea = new Random();
                nbo = nbAlea.Next(0, 10);
                Console.WriteLine("Au joueur de choisir son nombre entre 0 et 10");
                //success = Int32.TryParse(Console.ReadLine(), out nbu );
                //while(!success)
                //{
                //Console.WriteLine("vous devez entrer un nombre entier"); 
                //success = Int32.TryParse(Console.ReadLine(),out nbu);
                //}
                //nbu = Int32.Parse(Console.ReadLine());

                nbEssai = 1;
                nbu = SaisieNombre();

                //Tant que le nombre de la machine n'est pas decouvert

                while (nbo != nbu && nbEssai < NBCOUP)
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
                    //success = Int32.TryParse(Console.ReadLine(), out nbu);
                    // while (!success)
                    //{
                    // Console.WriteLine("Vous devez entrer un nombre entier");
                    //success = Int32.TryParse(Console.ReadLine(), out nbu);
                    //}
                    nbu = SaisieNombre();
                    nbEssai++;
                }
                if (nbo == nbu)
                {
                    Console.WriteLine("c'est gagner");
                }
                else
                {
                    Console.WriteLine("Votre nombre de tentatives a depasser 5 : perdu ");
                }
                //Console.ReadKey();
                Console.WriteLine("soihaitez-vous faire une autre partie ? (O/N)");
                success = char.TryParse(Console.ReadLine(), out reponse);
                while(!success) 
                {
                    Console.WriteLine("vous devez entrer O ou N");
                    success = char.TryParse(Console.ReadLine(), out reponse);

                }
                // Validation de la réponse
                while (reponse != 'O' && reponse != 'N')
                {
                    Console.WriteLine("Veuillez entrer 'O' pour Oui ou 'N' pour Non.");
                    success2 = char.TryParse(Console.ReadLine(), out reponse);
                    while (!success)
                    {
                        Console.WriteLine("vous devez entrer O ou N");
                        success2 = char.TryParse(Console.ReadLine(), out reponse);

                    }
                }

            } while (reponse != 'N');
        }
    }
}