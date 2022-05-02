using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GegevenOpslag_Oefening_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string keuze = "";
            while (keuze != "s")
            {
                keuze = MenuClass.KeuzeMenu();
                if (keuze == "n")
                {
                    Console.Clear();
                    Console.WriteLine("Geef de bestandsnaam op.");
                    string bestandsNaam = Console.ReadLine();
                    bestandsNaam = @"C:\" + bestandsNaam;
                    Console.WriteLine("Geef een tekst in en duw op ENTER.");
                    string tekst = Console.ReadLine();
                    if (File.Exists(bestandsNaam) == true) Console.WriteLine("Bestand bestaat al."); // here
                }
            }
        }

        
    }
}
