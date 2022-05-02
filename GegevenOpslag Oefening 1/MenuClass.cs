using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GegevenOpslag_Oefening_1
{
    class MenuClass
    {
        public static string KeuzeMenu()
        {
            Console.WriteLine("Een nieuwe tekst maken (N)\nTekst toevoegen aan een bestaande tekst (T)\nEen bestaande tekst wissen (W)\nToon de inhoud (I)\nStoppen met werken (S)");
            string keuze = Console.ReadLine();
            keuze = keuze.ToLower();
            return keuze;
        }

        public static void BewaarBestand(string bestandsNaam, bool toevoegen, string tekst)
        {

        }

        public static string ToonBestand(string bestandsNaam)
        {
            return "";
        }
    }
}
