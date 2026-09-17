using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace B1._1___Grundlegendes_Konsolenprojekt
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Random greeting text.
            Random random = new Random();
            string[] text = {" schön dass du da bist!", " schön dich kennen zu lernen!", " wir wünschen dir viel Spaß an der SAE", " ich hoffe du wirst viel Spaß haben!"};
            int randomText = random.Next(text.Length);

            //Welcome messages
            string welcome = "Willkommen auf der SAE";
            string introduce = "Wie heißt du?";
            string welcome2 = "Hallo ";

            //Names
            string name = "";
            string banName = "Fabienne";

            //error messages
            string error = "Das ist kein echter Name, bitte versuche es nocheinmal";
            string banText = "Zugriff verweigert";
               
            //Console output
            Console.WriteLine(welcome);
            Console.WriteLine(introduce);
            name = Console.ReadLine();

            if (name.Length <= 1)
            { Console.WriteLine(error); }
            else if (name == banName) 
            { Console.WriteLine(banText); }
            else { Console.WriteLine(welcome2 + name + text[randomText]); }
        }
    }
}
