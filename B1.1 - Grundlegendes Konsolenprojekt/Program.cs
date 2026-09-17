using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1._1___Grundlegendes_Konsolenprojekt
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Randomizer
            Random random = new Random();

            string[] names = { "Janick", "Sven", "Leon", "Steven" };
            int randomName = random.Next(names.Length);

            //Welcome Text
            string welcome = "Willkommen auf der SAE";
            string introduce = "Wie heißt du?";

            //console text
            Console.WriteLine(welcome);
            Console.WriteLine(introduce);
            Console.WriteLine(names[randomName]);

            string welcome2 = "Hallo " + names[randomName];
            string welcome3 = "! Schön dass du da bist.";

            Console.WriteLine(welcome2 + welcome3);




        }
    }
}
